using System;
using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.UIs
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;

        private void Awake()
        {
            if(winPanel.activeSelf)
                winPanel.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced  += HandleOnMissionSucced;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;
        }
        private void HandleOnMissionSucced()
        {
            if(!winPanel.activeSelf)
                winPanel.SetActive(true);
        }
    }

}

