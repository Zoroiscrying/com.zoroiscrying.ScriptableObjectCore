using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/Vector2List", fileName = "new Vector2List SO")]
    public sealed class Vector2ValueListSO : ValueListSO<Vector2, Vector2EventSO> { }
}