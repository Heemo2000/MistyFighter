using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "MovesDataSO", menuName = "MovesData/MovesDataSO")]
    public class MovesData : ScriptableObject
    {
        public string displayName;
        public string element;
        public int attack;
        public int expToUse;
    }
}
