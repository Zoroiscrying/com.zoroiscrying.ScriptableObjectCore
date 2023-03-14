using UnityEngine;

namespace Zoroiscrying.ScriptableObjectCore
{
    public class BaseSO : ScriptableObject
    {
        [SerializeField] [TextArea(3, 6)] private string developerDescription;
    }

}