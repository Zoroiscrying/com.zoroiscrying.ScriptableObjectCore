﻿using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    [EditorIcon("typeList")]
    [CreateAssetMenu(menuName = "Unity Core/Unity SO/Value Lists/QuaternionList", fileName = "new QuaternionList SO")]
    public sealed class QuaternionValueListSO : ValueListSO<Quaternion, QuaternionEventSO> { }
}