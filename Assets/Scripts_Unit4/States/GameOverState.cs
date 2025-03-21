using System.Collections;
using System.Collections.Generic;
using Golf;
using UnityEngine;

namespace Golf_Unit4
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        public LevelController levelController;

        public void Restart()
        {   
            levelController.ClearStones();

            Exit();
            mainMenuState.Enter();
        }
    }
}
