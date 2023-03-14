using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace com.zoroiscrying.ScriptableObjectCore
{
    public abstract class VariableSO<TD, TE, TF> : BaseVariableSO<TD>, ISerializationCallbackReceiver
        where TE : EventSO<TD>
        where TF : FunctionSO<TD, TD>
    {
        public virtual TD OldValue
        {
            get { return _oldValue; }
        }
        
        private TD _oldValue;

        public override TD Value
        {
            get => runtimeValue;
            set => SetValue(value);
        }

        [SerializeField] private TE changedEventSo;

        [SerializeField] private bool triggerChangedEventOnEnable = default;

        public TE ChangedEventSo
        {
            get => changedEventSo;
            set => changedEventSo = value;
        }
        
        /// <summary>
        /// When setting the value of a Variable the new value will be piped through all the pre change transformers, which allows you to create custom logic and restriction on for example what values can be set for this Variable.
        /// </summary>
        /// <value>Get the list of pre change transformers.</value>
        public List<TF> PreChangeTransformers
        {
            get => preChangeTransformers;
            set
            {
                if (value == null)
                {
                    preChangeTransformers.Clear();
                }
                else
                {
                    preChangeTransformers = value;
                }
            }
        }

        [SerializeField]
        private List<TF> preChangeTransformers = new List<TF>();

        protected abstract bool ValueEquals(TD other);

        public override void OnBeforeSerialize()
        {
            // Dont know what this happens
        }

        private void OnValidate()
        {
            initialValue = RunPreChangeTransformers(InitialValue);
            runtimeValue = RunPreChangeTransformers(runtimeValue);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            TriggerInitialEvents();
        }

        protected override void SetInitialValues()
        {
            base.SetInitialValues();
            _oldValue = InitialValue;
        }

        private void TriggerInitialEvents()
        {
            if (ChangedEventSo != null && triggerChangedEventOnEnable)
            {
                ChangedEventSo.RaiseEvent(Value);
            }
        }

        public override void ResetValue(bool shouldTriggerEvents = false)
        {
            if (!shouldTriggerEvents)
            {
                _oldValue = runtimeValue;
                runtimeValue = initialValue;
            }
            else
            {
                SetValue(InitialValue);
            }
        }
        
        /// <summary>
        /// Set the Variable value.
        /// </summary>
        /// <param name="newValue">The new value to set.</param>
        /// <returns>`true` if the value got changed, otherwise `false`.</returns>
        public bool SetValue(TD newValue, bool forceEvent = false)
        {
            var preProcessedNewValue = RunPreChangeTransformers(newValue);
            var changeValue = !ValueEquals(preProcessedNewValue);
            var triggerEvents = changeValue || forceEvent;

            if (changeValue)
            {
                _oldValue = runtimeValue;
                runtimeValue = preProcessedNewValue;
            }

            if (triggerEvents)
            {
                if (changedEventSo != null) { changedEventSo.RaiseEvent(runtimeValue); }
                BroadcastChangeEvent();
            }

            return changeValue;
        }
        
        private TD RunPreChangeTransformers(TD value)
        {
            if (preChangeTransformers.Count <= 0)
            {
                return value;
            }

            var preProcessedValue = value;
            for (var i = 0; i < preChangeTransformers.Count; ++i)
            {
                var Transformer = preChangeTransformers[i];
                if (Transformer != null)
                {
                    preProcessedValue = Transformer.Call(preProcessedValue);
                }
            }


            return preProcessedValue;
        }
        
    }
}