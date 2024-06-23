using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game
{
    [CreateAssetMenu(fileName = "MystiesSO", menuName = "MystiesData/MystiesSO")]
    public class MystiesData : ScriptableObject
    {
        // Creating Fields / Initializing Field
        [SerializeField] string _displayName;
        [SerializeField] string _element;
        [SerializeField] int _maxHP;
        [SerializeField] int _maxExp;
    }

}
