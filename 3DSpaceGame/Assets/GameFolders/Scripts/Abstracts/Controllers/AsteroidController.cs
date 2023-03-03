using UnityEngine;
using SpaceGame.Controllers;
using SpaceGame.Managers;

namespace SpaceGame.Abstracts.Controllers
{
    public abstract class AsteroidController : MonoBehaviour
    {
        [SerializeField] private float tumble = 0.5f;
        
        void Awake()
        {
            GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
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
