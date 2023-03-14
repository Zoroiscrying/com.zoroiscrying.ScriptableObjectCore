using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/BoolEvent", fileName = "New BoolEvent SO")]
    public sealed class BoolEventSO : EventSO<bool> { }
}