using System;
using SpaceGame.Abstracts.Utilities;
using UnityEngine;

namespace SpaceGame.Managers
{
    public class SoundManager : SingeltonThisObjects<SoundManager>
    {

        private AudioSource[] audioSource;
        
        private void Awake()
        {
            SingeltonThisGameObject(this);
            audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if(!audioSource[index].isPlaying)
                audioSource[index].Play();
        }

        public void StopSound(int index)
        {
            if(audioSource[index].isPlaying)
                audioSource[index].Stop();
        }
    }
}

