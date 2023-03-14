using System;
using UnityEngine;
using UnityEngine.Events;

namespace com.zoroiscrying.ScriptableObjectCore
{
    // Listen to specific event, auto-bind to event.
    public class AbstractGameEventListener<TD, TE, TUe> : MonoBehaviour, ISOEventListener<TD> where TE : EventSO<TD> where TUe : UnityEvent<TD>
    {
        [SerializeField] private TE eventToListen;

        [SerializeField] private TUe responseUnityEvent;

        private void OnEnable()
        {
            if (eventToListen)
            {
                eventToListen.RegisterListener(this);
            }
        }

        private void OnDisable()
        {
            if (eventToListen)
            {
                eventToListen.UnregisterListener(this);
            }
        }

        public virtual void OnEventRaised(TD data)
        {
            // do something.
            responseUnityEvent?.Invoke(data);
        }
    }
}