using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/BoolList", fileName = "new BoolValueList SO")]
    public sealed class BoolValueListSO : ValueListSO<bool, BoolEventSO> { }
}