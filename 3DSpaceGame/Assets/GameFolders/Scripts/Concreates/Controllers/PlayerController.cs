using System;
using SpaceGame.Inputs;
using SpaceGame.Managers;
using SpaceGame.Movements;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float turnSpeed = 10f;
        [SerializeField] private float force = 55f;

        [SerializeField] private ParticleSystem leftSmoke;
        [SerializeField] private ParticleSystem rightSmoke;

        private DefaultInput input;
        private Rotator rotator;
        private Mover mover;
        private Fuel fuel;

        private bool canMove;
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

        private void Start()
        {
            canMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
        }

        private void Update()
        {
            if(!canMove) 
                return;
            
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
            
            TurnEffects();

        }

        private void TurnEffects()
        {
            if (leftRight == -1)
            {
                if (leftSmoke.isStopped)
                {
                    leftSmoke.Play();
                }
            }
            else if (leftRight == 1)
            {
                if (rightSmoke.isStopped)
                {
                    rightSmoke.Play();
                }
            }
            else if (leftRight == 0)
            {
                leftSmoke.Stop();
                rightSmoke.Stop();
            }
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
        
        private void HandleOnEventTrigger()
        {
            canMove = false;
            canForceUp = false;
            leftRight = 0;
            fuel.FuelIncrease(0f);
        }
    }
}


