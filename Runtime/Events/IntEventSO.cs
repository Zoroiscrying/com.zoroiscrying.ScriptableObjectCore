using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/IntEvent", fileName = "New IntEvent SO")]
    public sealed class IntEventSO : EventSO<int>
    {
        
    }
}