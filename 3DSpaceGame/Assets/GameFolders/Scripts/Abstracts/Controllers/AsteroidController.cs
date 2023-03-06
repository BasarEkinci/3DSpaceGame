using UnityEngine;
using SpaceGame.Controllers;
using SpaceGame.Managers;

namespace SpaceGame.Abstracts.Controllers
{
    public abstract class AsteroidController : MonoBehaviour
    {
        void Awake()
        {
          
        }
        
       private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
