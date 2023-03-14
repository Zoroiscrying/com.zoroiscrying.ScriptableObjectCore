using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    /// <summary>
    /// Generic base class for Events Scriptable Objects.
    /// </summary>
    /// <typeparam name="TD">Passed in data type for this event</typeparam>
    public class EventSO<TD> : BaseEventSO
    {
        public TD InspectorRaiseValue
        {
            get => inspectorRaiseValue;
        }

        [Tooltip("Value that will be used when using the Raise button in the editor inspector.")]
        [SerializeField] private TD inspectorRaiseValue = default(TD);
        
        public List<TD> ReplayBuffer
        {
            get => _replayBuffer.ToList();
        }
        
        private Queue<TD> _replayBuffer = new Queue<TD>();

        public int ReplayBufferSize
        {
            get => replayBufferSize;
            set => replayBufferSize = value;
        }
        
        [SerializeField] [Range(0, 10)]
        [Tooltip("The number of old values being replayed when someone subscribes to this event.")]
        private int replayBufferSize = 1;
        
        [SerializeField]
        protected event Action<TD> onEvent;

        private void OnDisable()
        {
            //Clear all delegates when exiting play mode
            if (onEvent != null)
            {
                foreach (var del in onEvent.GetInvocationList())
                {
                    onEvent -= (Action<TD>)del;
                }
            }
        }

        /// <summary>
        /// Raise the event, passing in the data.
        /// </summary>
        /// <param name="data">The data passed with the event.</param>
        public void RaiseEvent(TD data)
        {
            base.RaiseEvent();
            onEvent?.Invoke(data);
            AddToReplayBuffer(data);
        }

        /// <summary>
        /// Used in Editor scripts
        /// </summary>
        /// <param name="data"></param>
        public void RaiseEditor(TD data) => RaiseEvent(data);

        
        /// <summary>
        /// Register a handler to be called when the Event triggers.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Register(Action<TD> action)
        {
            onEvent += action;
            ReplayBufferToSubscriber(action);
        }
        
        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Unregister(Action<TD> action)
        {
            onEvent -= action;
        }
        
        /// <summary>
        /// Unregister all handlers that were registered using the `Register` method.
        /// </summary>
        public override void UnregisterAll()
        {
            base.UnregisterAll();
            onEvent = null;
        }
        
        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        /// <param name="replayEventsBuffer">Whether to use the replay event buffer.</param>
        public void RegisterListener(ISOEventListener<TD> listener, bool replayEventsBuffer = false)
        {
            onEvent += listener.OnEventRaised;
            if (replayEventsBuffer)
            {
                ReplayBufferToSubscriber(listener.OnEventRaised);
            }
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(ISOEventListener<TD> listener)
        {
            onEvent -= listener.OnEventRaised;
        }
        
        /// <summary>
        /// Add the data to the replay buffer.
        /// </summary>
        /// <param name="data"></param>
        protected void AddToReplayBuffer(TD data)
        {
            if (replayBufferSize > 0)
            {
                while (_replayBuffer.Count >= replayBufferSize) { _replayBuffer.Dequeue(); }
                _replayBuffer.Enqueue(data);
            }
        }

        /// <summary>
        /// Pass all the data in the buffer to a specific action
        /// How can this function be used?
        /// </summary>
        /// <param name="action">The action using all the data in the buffer</param>
        private void ReplayBufferToSubscriber(Action<TD> action)
        {
            if (replayBufferSize > 0 && _replayBuffer.Count > 0)
            {
                var enumerator = _replayBuffer.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        action(enumerator.Current);
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
        }
    }
}