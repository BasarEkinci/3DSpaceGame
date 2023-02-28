using System;
using SpaceGame.Inputs;
using SpaceGame.Movements;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float turnSpeed = 10f;
        [SerializeField] private float force = 55f;
        private DefaultInput input;
        
        private bool isForceUp;
        private float leftRight;
        private Rotator rotator;
        
        private Mover mover;
        public float TurnSpeed => turnSpeed;
        public float Force=> force;

        private void Awake()
        {
            input = new DefaultInput();
            mover = new Mover(this);
            rotator = new Rotator(this);
        }

        private void LateUpdate()
        {
            if (input.IsForceUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }

            leftRight = input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (isForceUp)
            {
                mover.FixedTick();
            }

            rotator.FixedTick(leftRight);
        }
    }
}


