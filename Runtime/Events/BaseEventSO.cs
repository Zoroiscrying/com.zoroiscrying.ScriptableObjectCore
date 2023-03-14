using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    public class BaseEventSO : BaseSO, ISerializationCallbackReceiver
    {
        /// <summary>
        /// Void Event
        /// </summary>
        public event Action OnEventNoValue;

        public virtual void RaiseEvent()
        {
            OnEventNoValue?.Invoke();
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="del"></param>
        public void Register(Action del)
        {
            OnEventNoValue += del;
        }

        /// <summary>
        /// Unregister handler that was registered using the 'Register' method.
        /// </summary>
        /// <param name="del"></param>
        public void Unregister(Action del)
        {
            OnEventNoValue -= del;
        }

        /// <summary>
        /// Unregister all handles that were registered using the 'Register' method.
        /// </summary>
        public virtual void UnregisterAll()
        {
            OnEventNoValue = null;
        }

        /// <summary>
        /// Register a listener that in turn trigger all its associated handlers when this event triggers
        /// </summary>
        /// <param name="listener"></param>
        public void RegisterListener(ISOEventListener listener)
        {
            OnEventNoValue += listener.OnEventRaised;
        }
        
        /// <summary>
        /// Unregister a listener that in turn trigger all its associated handlers when this event triggers
        /// </summary>
        /// <param name="listener"></param>
        public void UnregisterListener(ISOEventListener listener)
        {
            OnEventNoValue -= listener.OnEventRaised;
        }

        public void OnBeforeSerialize() { }
        
        public void OnAfterDeserialize()
        {
            // Clear all delegates when the so is deserialized to prevent non-runtime invocations
            if (OnEventNoValue != null)
            {
                foreach (var del in OnEventNoValue.GetInvocationList())
                {
                    OnEventNoValue -= (Action)del;
                }
            }
        }
    }
}