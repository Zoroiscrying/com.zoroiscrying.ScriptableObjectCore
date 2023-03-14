using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/ColliderEvent", fileName = "New ColliderEvent SO")]
    public sealed class ColliderEventSO : EventSO<Collider>
    {
        
    }
}