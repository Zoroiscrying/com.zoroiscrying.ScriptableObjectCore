using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/CollisionVariable", fileName = "New CollisionVariable SO")]
    public sealed class CollisionVariableSO : VariableSO<Collision, CollisionlEventSO, CollisionCollisionFunctionSO>
    {
        protected override bool ValueEquals(Collision other)
        {
            return Value == other;
        }
    }
}