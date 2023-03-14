using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/QuaternionEvent", fileName = "New QuaternionEvent SO")]
    public sealed class QuaternionEventSO : EventSO<Quaternion>
    {
        
    }
}