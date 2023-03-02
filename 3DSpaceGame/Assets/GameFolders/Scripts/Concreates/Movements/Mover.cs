using SpaceGame.Controllers;
using UnityEngine;

namespace SpaceGame.Movements
{
    public class Mover
    {
        private Rigidbody rigidbody;
        private PlayerController playerController;

        public Mover(PlayerController playerController)
        {
            this.playerController = playerController;
            rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            rigidbody.AddRelativeForce(Vector3.up * (Time.deltaTime * playerController.Force));
        }
    }
}


