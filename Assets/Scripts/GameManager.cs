using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public enum GameState { None, Start, PlayerTurn, EnemyTurn, Won, Lost }

    public class GameManager : MonoBehaviour
    {
        GameState gameState;
        public GameState GameState
        {
            get { return gameState; }
        }
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    }

}
