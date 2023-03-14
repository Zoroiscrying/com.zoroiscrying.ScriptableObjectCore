using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Zoroiscrying.ScriptableObjectCore
{
    public abstract class BaseVariableSO : BaseSO
    {
        public String Id
        {
            get => id;
            set => id = value;
        }

        [SerializeField] private String id = default;
        
        /// <summary>
        /// The variable value as an 'object'.
        /// </summary>
        public abstract object BaseValue { get; set; }

        /// <summary>
        /// Abstract method that could be implemented to reset the Variable value.
        /// </summary>
        /// <param name="shouldTriggerEvents"> Used to determine whether to trigger events </param>
        public abstract void ResetValue(bool shouldTriggerEvents = false);
    }
    
    public class BaseVariableSO<TD> : BaseVariableSO, IEquatable<BaseVariableSO<TD>>, ISerializationCallbackReceiver
    {
        public virtual TD InitialValue
        {
            get { return initialValue; }
        }
        
        [SerializeField]
        protected TD initialValue = default(TD);
        
        [NonSerialized] protected TD runtimeValue;
        
        // Runtime event for Value Changed Event of Base Variable
        protected event Action<TD> onValueChanged = delegate(TD d) {  };

        /// <summary>
        /// The variable value as an object, normally the property 'Value' should be used.
        /// </summary>
        public override object BaseValue
        {
            get => runtimeValue;
            set => Value = (TD)value;
        }
        
        /// <summary>
        /// The Variable value as a property.
        /// </summary>
        /// <returns>Get or set the Variable value.</returns>
        public virtual TD Value
        {
            get => runtimeValue;
            set
            {
                var oldValue = runtimeValue;
                runtimeValue = (TD) value;
                if (!runtimeValue.Equals(oldValue))
                {
                    RaiseValueChangedEvent(runtimeValue);   
                }
            }
        }

        public virtual void OnBeforeSerialize()
        {
            //
        }

        /// <summary>
        /// The deserialization happens before the game exits
        /// </summary>
        public void OnAfterDeserialize()
        {
            SetInitialValues();
        }

        protected virtual void OnEnable()
        {
            SetInitialValues();
        }

        protected virtual void SetInitialValues()
        {
            runtimeValue = InitialValue;
        }
        
        /// <summary>
        /// Code version for change event invocation, used for UI Panel Controller
        /// </summary>
        /// <param name="data"></param>
        protected void RaiseValueChangedEvent(TD data)
        {
            onValueChanged?.Invoke(data);
        }

        /// <summary>
        /// Used to update listeners even if the data hasn't been changed
        /// </summary>
        public void BroadcastChangeEvent()
        {
            onValueChanged?.Invoke(runtimeValue);
        }

        public void RegisterChangeValueListener(Action<TD> response)
        {
            if (onValueChanged!=null)
            {
                onValueChanged += response;   
            }
        }

        public void UnRegisterChangeValueListener(Action<TD> response)
        {
            if (onValueChanged!=null)
            {
                onValueChanged -= response; 
            }  
        }

        public bool Equals(BaseVariableSO<TD> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other) && EqualityComparer<TD>.Default.Equals(Value, other.Value) && EqualityComparer<TD>.Default.Equals(runtimeValue, other.runtimeValue);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BaseVariableSO<TD>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ EqualityComparer<TD>.Default.GetHashCode(Value);
                hashCode = (hashCode * 397) ^ EqualityComparer<TD>.Default.GetHashCode(runtimeValue);
                return hashCode;
            }
        }
        
        /// <summary>
        /// Implementation should be done for variables that inherit this class
        /// </summary>
        /// <param name="shouldTriggerEvents"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void ResetValue(bool shouldTriggerEvents = false)
        {
            throw new NotImplementedException();
        }
    }
}