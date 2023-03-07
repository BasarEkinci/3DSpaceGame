using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame.UIs
{
    public class OpenLinks : MonoBehaviour
    {
        public void InstagramButton()
        {
            Application.OpenURL("https://www.instagram.com/basar.ekincii/");
        }

        public void GitHubButton()
        {
            Application.OpenURL("https://github.com/BasarEkinci");
        }

        public void LinkedinButton()
        {
            Application.OpenURL("https://www.linkedin.com/in/ismail-başar-ekinci-446674202/");
        }

        public void TwitterButton()
        {
            Application.OpenURL("https://twitter.com/BasarEkincii");
        }
    }
}

