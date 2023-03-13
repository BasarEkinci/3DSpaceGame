using System;
using UnityEngine;
using SpaceGame.Controllers;
using SpaceGame.Managers;

namespace SpaceGame.Abstracts.Controllers
{
    public abstract class AsteroidController : MonoBehaviour
    {
        [SerializeField] private Vector3 turnAxis;
        private void Update()
        {
            transform.Rotate(turnAxis * 20 * Time.deltaTime,Space.Self);
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
