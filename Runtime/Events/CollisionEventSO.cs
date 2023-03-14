using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/CollisionEvent", fileName = "New CollisionEvent SO")]
    public sealed class CollisionlEventSO : EventSO<Collision>
    {
        
    }
}