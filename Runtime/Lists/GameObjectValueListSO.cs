using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/GameObjectList", fileName = "new GameObjectList SO")]
    public sealed class GameObjectValueListSO : ValueListSO<GameObject, GameObjectEventSO> { }
}