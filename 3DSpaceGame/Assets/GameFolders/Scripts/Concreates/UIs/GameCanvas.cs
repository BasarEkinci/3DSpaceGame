using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceGame.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private TMP_Text levelText;

        private void Update()
        {
            levelText.text = "Level: " + SceneManager.GetActiveScene().buildIndex;
        }
    }    
}


