using System;
using System.Collections;
using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    public abstract class BaseValueListSO : BaseSO
    {
        /// <summary>
        /// Event for when the list is cleared.
        /// </summary>
        public BaseEventSO Cleared;

        protected abstract IList ValueList { get; }

        /// <summary>
        /// Whether to clear the list on enable
        /// </summary>
        [SerializeField] protected bool clearOnEnable;

        public void Clear()
        {
            ValueList.Clear();
            if (Cleared != null)
            {
                Cleared.RaiseEvent();
            }
        }

        private void OnEnable()
        {
            if (clearOnEnable)
            {
                Clear();
            }
        }
    }
}