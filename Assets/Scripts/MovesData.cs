using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "MovesDataSO", menuName = "MovesData/MovesDataSO")]
    public class MovesData : ScriptableObject
    {
        [SerializeField] public string _displayName;
        [SerializeField] public string _element;
        [SerializeField] public int _attack;
        [SerializeField] public int _expToUse;
    }
}
