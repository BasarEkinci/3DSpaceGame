using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;


namespace SpaceGame.UIs
{
    public class WinPanel : MonoBehaviour
    {
        public void NextLevelButton()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void MainMenuButton()
        {
            GameManager.Instance.LoadMenu();
        }
    }
}


