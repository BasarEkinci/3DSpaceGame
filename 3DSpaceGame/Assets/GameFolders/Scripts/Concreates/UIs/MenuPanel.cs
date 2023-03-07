using System.Collections;
using System.Collections.Generic;
using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public GameObject linksPanel;
        public GameObject menuPanel;
        public void StartGameButton()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitGameButton()
        {
            GameManager.Instance.Exit();
        }

        public void LinksButton()
        {
            if(!linksPanel.activeSelf)
                linksPanel.SetActive(true);
            
            if(menuPanel.activeSelf)
                menuPanel.SetActive(false);
        }

        public void CloseLinksPanel()
        {
            if(linksPanel.activeSelf)
                linksPanel.SetActive(false);
            
            if(!menuPanel.activeSelf)
                menuPanel.SetActive(true);
        }
    }
}

