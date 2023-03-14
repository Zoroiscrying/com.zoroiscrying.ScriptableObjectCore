using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/GameObjectVariable", fileName = "New GameObjectVariable SO")]
    public sealed class GameObjectVariableSO : VariableSO<GameObject, GameObjectEventSO, GameObjectGameObjectFunctionSO>
    {
        protected override bool ValueEquals(GameObject other)
        {
            return Value == other;
        }
    }
}