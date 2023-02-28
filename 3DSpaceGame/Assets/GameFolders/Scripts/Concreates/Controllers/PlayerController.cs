using System;
using SpaceGame.Inputs;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float force;
        private Rigidbody rigidBody;
        private DefaultInput input;
        private bool isForceUp;
        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody>();
            input = new DefaultInput();
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
                rigidBody.AddForce(Vector3.up * (force * Time.deltaTime));
            }
        }
    }
}


