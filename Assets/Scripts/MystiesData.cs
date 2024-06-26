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
        public string displayName;
        public string element;
        public int maxHP;
        public int maxExp;
        public Sprite image;
    }

}
