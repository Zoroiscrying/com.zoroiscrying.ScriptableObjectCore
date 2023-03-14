using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/DoubleVariable", fileName = "New DoubleVariable SO")]
    public sealed class DoubleVariableSO : EquatableVariableSO<double, DoubleEventSO, DoubleDoubleFunctionSO>
    {
        
    }
}