using System;
using SpaceGame.Abstracts.Controllers;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;
        [Range(0f, 1f)] [SerializeField] private float factor;
        private Vector3 startPosition;

        private void Awake()
        {
            startPosition = transform.position;
        }

        private void Update()
        {
            Vector3 offset = direction * factor;
            transform.position = offset + startPosition;
        }
    }
}

