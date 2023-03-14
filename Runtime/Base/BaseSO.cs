using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    public class BaseSO : ScriptableObject
    {
        [SerializeField] [TextArea(3, 6)] private string developerDescription;
    }

}