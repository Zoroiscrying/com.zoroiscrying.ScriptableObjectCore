using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/Vector3Variable", fileName = "New Vector3Variable SO")]
    public sealed class Vector3VariableSO : EquatableVariableSO<Vector3, Vector3EventSO, Vector3Vector3FunctionSO>
    {
        
    }
}