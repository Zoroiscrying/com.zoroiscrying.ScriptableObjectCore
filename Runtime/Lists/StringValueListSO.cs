﻿using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/StringList", fileName = "new StringList SO")]
    public sealed class StringValueListSO : ValueListSO<string, StringEventSO> { }
}