using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/IntList", fileName = "new IntList SO")]
    public sealed class IntValueListSO : ValueListSO<int, IntEventSO> { }
}