using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame.Movements
{
    public class Mover
    {
        private Rigidbody rigidbody;

        public Mover(Rigidbody rigidbody)
        {
            this.rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            this.rigidbody.AddRelativeForce(Vector3.up * (Time.deltaTime * 55f));
        }
    }
}


