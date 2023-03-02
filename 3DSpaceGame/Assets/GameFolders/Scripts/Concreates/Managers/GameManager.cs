using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public static GameManager Instance { get; private set; }
        private void Awake()
        {
            SingeltonThisGameObject();
        }

        private void SingeltonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();// if(OnGameOver != null){ GameOver(); }
        }
    }
}


