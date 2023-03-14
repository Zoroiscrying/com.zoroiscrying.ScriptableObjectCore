using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/StringVariable", fileName = "New StringVariable SO")]
    public sealed class StringVariableSO : EquatableVariableSO<string, StringEventSO, StringStringFunctionSO>
    {
        
    }
}