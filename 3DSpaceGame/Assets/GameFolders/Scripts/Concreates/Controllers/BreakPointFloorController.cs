using System;
using SpaceGame.Controllers;
using SpaceGame.Movements;
using UnityEngine;

public class BreakPointFloorController : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        PlayerController player = other.collider.GetComponent<PlayerController>();

        Fuel fuel = other.collider.GetComponent<Fuel>();
        
        if (player != null)
        {
            fuel.FuelIncrease(3f);
        }
    }
}
