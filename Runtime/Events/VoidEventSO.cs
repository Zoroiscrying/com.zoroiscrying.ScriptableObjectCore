using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/VoidEvent", fileName = "New VoidEvent SO")]
    public sealed class VoidEventSO : EventSO<Void>
    {
        public override void RaiseEvent()
        {
            RaiseEvent(new Void());
        }
    }
}