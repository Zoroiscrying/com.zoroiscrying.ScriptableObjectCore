using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/ColorEvent", fileName = "New ColorEvent SO")]
    public sealed class ColorEventSO : EventSO<Color>
    {
        
    }
}