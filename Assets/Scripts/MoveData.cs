using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "MoveDataSO", menuName = "MoveData/MoveDataSO")]
    public class MoveData : ScriptableObject
    {
        [SerializeField] string _displayName;
        [SerializeField] string _element;
        [SerializeField] int _attack;
        [SerializeField] int _expToUse;
    }
}
