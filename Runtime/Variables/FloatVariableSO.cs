using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/FloatVariable", fileName = "New FloatVariable SO")]
    public sealed class FloatVariableSO : EquatableVariableSO<float, FloatEventSO, FloatFloatFunctionSO>
    {
        
    }
}