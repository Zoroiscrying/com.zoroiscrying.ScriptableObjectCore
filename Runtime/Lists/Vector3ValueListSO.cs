using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/Vector3List", fileName = "new Vector3List SO")]
    public sealed class Vector3ValueListSO : ValueListSO<Vector3, Vector3EventSO> { }
}