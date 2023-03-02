using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartGameButton()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitGameButton()
        {
            GameManager.Instance.Exit();
        }
    }
}

