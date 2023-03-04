using System.Collections;
using SpaceGame.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceGame.Managers
{
    public class GameManager : SingeltonThisObjects<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;
        private void Awake()
        {
            SingeltonThisGameObject(this);
        }
        
        public void GameOver()
        {
            OnGameOver?.Invoke();// if(OnGameOver != null){ GameOver(); }
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenu()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Debug.Log("Exit proccess on triggered");
            Application.Quit();
        }
    }
}


