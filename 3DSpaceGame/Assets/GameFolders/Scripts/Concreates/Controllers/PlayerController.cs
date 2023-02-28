using System;
using SpaceGame.Inputs;
using SpaceGame.Movements;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private DefaultInput input;
        private bool isForceUp;
        private Mover mover;
        private void Awake()
        {
            input = new DefaultInput();
            mover = new Mover(GetComponent<Rigidbody>());
        }

        private void Update()
        {
            if (input.IsForceUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            if (isForceUp)
            {
                mover.FixedTick();
            }
        }
    }
}


