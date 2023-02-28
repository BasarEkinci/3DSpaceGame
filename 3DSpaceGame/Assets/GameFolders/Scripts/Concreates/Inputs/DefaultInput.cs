using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame.Inputs
{
    public class DefaultInput
    {
        private DefaultActions input;
        public bool IsForceUp { get; private set; }
        
        public DefaultInput()
        {
            input = new DefaultActions();
            input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();//True-false
            input.Enable();
        }
    }
}


