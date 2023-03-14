using System.Collections.Generic;
using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    /// <summary>
    /// This class is deprecated.
    /// </summary>
    /// <typeparam name="TD"></typeparam>
    public class BaseGameEventSO<TD> : ScriptableObject
    {
        [SerializeField] private TD defaultData;

        public readonly List<ISOEventListener<TD>> eventListeners = new List<ISOEventListener<TD>>();

        public void AddListener(ISOEventListener<TD> listener)
        {
            if (!eventListeners.Contains(listener))
            {
                eventListeners.Add(listener);
            }
        }
        
        public void RemoveListener(ISOEventListener<TD> listener)
        {
            if (eventListeners.Contains(listener))
            {
                eventListeners.Remove(listener);
            }
        }
        
        public void RaiseEvent(TD data)
        {
            foreach (var listener in eventListeners)
            {
                listener.OnEventRaised(defaultData);
            }
            // implement
        }
        
    }
}