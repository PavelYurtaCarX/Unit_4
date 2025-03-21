using System.Collections;
using System.Collections.Generic;
using Golf;
using TMPro;
using UnityEngine;

namespace Golf_Unit4
{
    public class GamePlayState : GameState
    {
        public LevelController levelController;
        public PlayerController playerController;
        public GameState gameOverState;
        public TMP_Text scoreText;

        protected override void OnEnable()
        {
            base.OnEnable();

            levelController.enabled = true;
            playerController.enabled = true;

            GameEvents.onCollisionStone += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
            OnStickHit();
        }


        private void OnStickHit()
        {
            scoreText.text = $"HScore : {levelController.score}";
        }
        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }

        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvents.onCollisionStone -= OnGameOver;

            levelController.enabled = false;
            playerController.enabled = false;
        }
    }
}
