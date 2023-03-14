using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/Vector2Variable", fileName = "New Vector2Variable SO")]
    public sealed class Vector2VariableSO : EquatableVariableSO<Vector2, Vector2EventSO, Vector2Vector2FunctionSO>
    {
        
    }
}