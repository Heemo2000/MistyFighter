using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public abstract class  Move : MonoBehaviour
    {
        [SerializeField]protected MovesData movesData;
        
        public abstract void Perform();
    }
}
