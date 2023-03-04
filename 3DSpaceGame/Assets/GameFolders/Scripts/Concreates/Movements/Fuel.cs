using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float maxFuel = 100f;
        [SerializeField] private float currentFuel;
        [SerializeField] private ParticleSystem particle;
        public bool IsEmpty => currentFuel < 1f;
        public float CurrentFuel => currentFuel / maxFuel;
        private void Awake()
        {
            currentFuel = maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            currentFuel += increase;
            currentFuel = Mathf.Min(currentFuel, maxFuel);
            if (particle.isPlaying)
            {
                particle.Stop();
            }
            
            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = Mathf.Max(currentFuel, 0);

            if (particle.isStopped)
            {
                particle.Play();
            }
            
            SoundManager.Instance.PlaySound(0);
        }
    }
}

