using UnityEngine;

namespace SpaceGame.Abstracts.Utilities
{
    public abstract class SingeltonThisObjects<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected void SingeltonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}


