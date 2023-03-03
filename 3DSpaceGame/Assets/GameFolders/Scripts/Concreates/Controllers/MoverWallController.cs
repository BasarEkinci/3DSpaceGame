using System;
using SpaceGame.Abstracts.Controllers;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;
        [SerializeField] private float speed = 1f;
        [SerializeField] private float directionFactor = 1f;
        
        private float factor;
        private Vector3 startPosition;
        private const float FULL_CIRCLE = Mathf.PI * 2f;
        private void Awake()
        {
            startPosition = transform.position;
        }
        private void Update()
        {
            float cycle = Time.time / speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
            
            factor = Mathf.Abs(sinWave);

            Vector3 offset = direction * (factor * directionFactor);
            transform.position = offset + startPosition;
        }
    }
}

