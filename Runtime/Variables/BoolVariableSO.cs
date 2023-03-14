using System.ComponentModel;
using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/BoolVariable", fileName = "New BoolVariable SO")]
    public sealed class BoolVariableSO : EquatableVariableSO<bool, BoolEventSO, BoolBoolFunctionSO>
    {
        
    }
}