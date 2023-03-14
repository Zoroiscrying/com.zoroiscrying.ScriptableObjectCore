using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/ColliderList", fileName = "new ColliderList SO")]
    public sealed class ColliderValueListSO : ValueListSO<Collider, ColliderEventSO> { }
}