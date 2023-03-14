using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/FloatList", fileName = "new FloatValueList SO")]
    public sealed class FloatValueListSO : ValueListSO<float, FloatEventSO> { }
}