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
        private Rotator rotator;
        private Mover mover;
        private Fuel fuel;
        
        private bool canForceUp;
        private float leftRight;
        public float TurnSpeed => turnSpeed;
        public float Force=> force;

        private void Awake()
        {
            input = new DefaultInput();
            mover = new Mover(this);
            rotator = new Rotator(this);
            fuel = GetComponent<Fuel>();
        }

        private void LateUpdate()
        {
            if (input.IsForceUp && !fuel.IsEmpty)
            {
                canForceUp = true;
            }
            else
            {
                canForceUp = false;
                fuel.FuelIncrease(0.005f);
            }
            leftRight = input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (canForceUp)
            {
                mover.FixedTick();
                fuel.FuelDecrease(0.2f);
            }
            rotator.FixedTick(leftRight);
        }
    }
}


