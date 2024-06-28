using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class Mystie : MonoBehaviour
    { 
        // Scriptable Objects
        [SerializeField]protected MystiesData mystieData;
        // Script Fields
        protected int currentHP;
        protected int currentExp;

        
        private void Start()
        {
            currentHP = mystieData.maxHP;
            currentExp = 0;
        }
    }
}
