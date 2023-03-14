using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeVariable")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Variables/ColorVariable", fileName = "New ColorVariable SO")]
    public sealed class ColorVariableSO : EquatableVariableSO<Color, ColorEventSO, ColorColorFunctionSO>
    {
        
    }
}