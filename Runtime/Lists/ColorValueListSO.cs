using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/ColorList", fileName = "new ColorList SO")]
    public sealed class ColorValueListSO : ValueListSO<Color, ColorEventSO> { }
}