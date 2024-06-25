using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UIElements;


namespace Game
{
    [CreateAssetMenu(fileName = "MystiesSO", menuName = "MystiesData/MystiesSO")]
    public class MystiesData : ScriptableObject
    {
        // Creating Fields / Initializing Field
        [SerializeField] public string _displayName;
        [SerializeField] public string _element;
        [SerializeField] public int _maxHP;
        [SerializeField] public int _maxExp;
        [SerializeField] public Sprite image;
    }

}
