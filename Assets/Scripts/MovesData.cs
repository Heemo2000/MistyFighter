using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "MovesDataSO", menuName = "MovesData/MovesDataSO")]
    public class MovesData : ScriptableObject
    {
        [SerializeField] string _displayName;
        [SerializeField] string _element;
        [SerializeField] int _attack;
        [SerializeField] int _expToUse;
    }
}
