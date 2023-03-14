using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/ColliderVariable", fileName = "New ColliderVariable SO")]
    public sealed class ColliderVariableSO : VariableSO<Collider, ColliderEventSO, ColliderColliderFunctionSO>
    {
        protected override bool ValueEquals(Collider other)
        {
            return Value == other;
        }
    }
}