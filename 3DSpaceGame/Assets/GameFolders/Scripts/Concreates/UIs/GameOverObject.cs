using System;
using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.UIs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;

        private void Awake()
        {
            if (gameOverPanel.activeSelf)//if game over panel is active,it sets it to inactive
            {
                gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }
        
        private void HandleOnGameOver()
        {
            if(!gameOverPanel.activeSelf)
                gameOverPanel.SetActive(true);
        }
    }

}

