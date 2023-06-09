﻿using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeEvent")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Events/GameObjectEvent", fileName = "New GameObjectEvent SO")]
    public sealed class GameObjectEventSO : EventSO<GameObject>
    {
        
    }
}