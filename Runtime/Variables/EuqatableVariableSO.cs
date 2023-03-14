using System;

namespace Zoroiscrying.ScriptableObjectCore
{
    public abstract class EquatableVariableSO<TD, TE, TF> : VariableSO<TD, TE, TF>
        where TD : IEquatable<TD>
        where TE : EventSO<TD>
        where TF : FunctionSO<TD, TD>
    {
        protected override bool ValueEquals(TD other)
        {
            return (Value == null && other == null) || (Value?.Equals(other) == true);
        }
    }
}