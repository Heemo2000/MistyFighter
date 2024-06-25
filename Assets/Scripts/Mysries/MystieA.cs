using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MystieA : MonoBehaviour
    { 
        // Scriptable Objects
        MystiesData mystieA;
        MovesData movesA;

        // Script Fields
        int _currentHP;
        int _currentExp;

        private void Awake()
        {
            
        }
        private void Start()
        {
            _currentHP = mystieA._maxHP;
            _currentExp = 0;
        }
    }
}
