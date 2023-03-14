using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/DoubleList", fileName = "new DoubleValueList SO")]
    public sealed class DoubleValueListSO : ValueListSO<double, DoubleEventSO> { }
}