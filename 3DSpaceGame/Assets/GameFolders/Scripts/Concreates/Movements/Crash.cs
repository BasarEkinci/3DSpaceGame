using System;
using System.Collections;
using SpaceGame.Managers;
using SpaceGame.Controllers;
using UnityEngine;


namespace SpaceGame.Movements
{
    public class Crash : MonoBehaviour
    {
        public ParticleSystem explosion;
        private PlayerController player;
        private void Awake()
        {
            player = GetComponent<PlayerController>();
            
            if(explosion.isPlaying)
                explosion.Stop();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstacle") && player.CanMove)
            {
                if(explosion.isStopped)
                    explosion.Play();

                SoundManager.Instance.PlaySound(3);
                
                Destroy(this.gameObject,0.5f);
            }
            else
            {
                SoundManager.Instance.StopSound(3);
            }
        }
    }
}

