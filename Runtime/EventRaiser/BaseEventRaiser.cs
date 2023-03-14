using System;
using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    /// <summary>
    /// Base Event Raiser Class for handling Scriptable Object Event Calling
    /// TODO::Do a Base Listed Event Raiser
    /// </summary>
    /// <typeparam name="TD">The data associated with this event raiser</typeparam>
    /// <typeparam name="TE">The event this raiser will invoke</typeparam>
    public class BaseEventRaiser<TD, TE> : MonoBehaviour
        where TE : EventSO<TD>
    {
        [SerializeField] private bool raiseOnStart;
        [SerializeField] private bool raiseOnce = true;
        
        private bool _raisedOnce = false;
        
        [SerializeField] private TE targetEvent;
        [SerializeField] private TD defaultData;

        private void Start()
        {
            if (raiseOnStart)
            {
                RaiseEventDefault();
            }
        }

        public void RaiseEventDefault()
        {
            RaiseEvent(GetDefaultData());
        }

        public void RaiseEvent(TD data)
        {
            if (_raisedOnce && raiseOnce)
            {
                return;
            }
            _raisedOnce = true;
            RaiseEvents(data);
        }

        /// <summary>
        /// This can help build custom data in child classes.
        /// </summary>
        /// <returns>The constructed default data.</returns>
        protected virtual TD GetDefaultData()
        {
            return defaultData;
        }
        
        protected virtual void RaiseEvents(TD data)
        {
            if (targetEvent != null)
            {
                targetEvent.RaiseEvent(data);   
            }
        }
    }
}