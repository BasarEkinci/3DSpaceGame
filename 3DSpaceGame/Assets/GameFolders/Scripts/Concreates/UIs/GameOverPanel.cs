using System;
using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;

namespace  SpaceGame.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void TryAgainButton()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void MainMenuButton()
        {
            GameManager.Instance.LoadMenu();
        }
    }
}


