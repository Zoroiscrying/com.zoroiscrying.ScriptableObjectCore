using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/CollisionList", fileName = "new CollisionList SO")]
    public sealed class CollisionValueListSO : ValueListSO<Collision, CollisionlEventSO> { }
}