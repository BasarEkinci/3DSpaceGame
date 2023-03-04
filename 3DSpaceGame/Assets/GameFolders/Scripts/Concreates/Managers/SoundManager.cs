using System;
using SpaceGame.Abstracts.Utilities;
using UnityEngine;

namespace SpaceGame.Managers
{
    public class SoundManager : SingeltonThisObjects<SoundManager>
    {
        private void Awake()
        {
            SingeltonThisGameObject(this);
        }
    }
}

