using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/IntVariable", fileName = "New IntVariable SO")]
    public sealed class IntVariableSO : EquatableVariableSO<int, IntEventSO, IntIntFunctionSO>
    {
        
    }
}