using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/QuaternionVariable", fileName = "New QuaternionVariable SO")]
    public sealed class QuaternionVariableSO : EquatableVariableSO<Quaternion, QuaternionEventSO, QuaternionQuaternionFunctionSO>
    {
        
    }
}