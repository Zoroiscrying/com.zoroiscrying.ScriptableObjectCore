using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/StringEvent", fileName = "New StringEvent SO")]
    public sealed class StringEventSO : EventSO<string>
    {
        
    }
}