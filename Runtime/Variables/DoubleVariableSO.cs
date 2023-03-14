using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/DoubleVariable", fileName = "New DoubleVariable SO")]
    public sealed class DoubleVariableSO : EquatableVariableSO<double, DoubleEventSO, DoubleDoubleFunctionSO>
    {
        
    }
}