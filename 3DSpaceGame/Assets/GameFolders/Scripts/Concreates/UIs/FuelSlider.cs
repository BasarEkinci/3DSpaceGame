using SpaceGame.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceGame.UIs
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider slider;
        private Fuel fuel;
        private void Awake()
        {
            slider = GetComponent<Slider>();
            fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            slider.value = fuel.CurrentFuel;
        }
    }
}


