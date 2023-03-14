using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/CollisionEvent", fileName = "New CollisionEvent SO")]
    public sealed class CollisionlEventSO : EventSO<Collision>
    {
        
    }
}