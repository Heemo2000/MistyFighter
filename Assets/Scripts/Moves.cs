using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : ScriptableObject
{
    [SerializeField] string _displayName;
    [SerializeField] string _element;
    [SerializeField] int _attack;
    [SerializeField] int _expToUse;
}
