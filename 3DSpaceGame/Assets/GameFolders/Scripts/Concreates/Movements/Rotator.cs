using System.Collections;
using System.Collections.Generic;
using SpaceGame.Controllers;
using UnityEngine;

namespace SpaceGame.Movements
{
    public class Rotator
    {
        private Rigidbody rigidbody;
        private PlayerController playerController;

        public Rotator(PlayerController playerController)
        {
            this.playerController = playerController;
            rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                if (rigidbody.freezeRotation) 
                    rigidbody.freezeRotation = false;
                return;
            }

            if (!rigidbody.freezeRotation)
                rigidbody.freezeRotation = true;
            
            playerController.transform.Rotate(Vector3.back * (Time.deltaTime * direction * playerController.TurnSpeed));
        }
    }
}


