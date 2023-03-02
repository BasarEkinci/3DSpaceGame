using SpaceGame.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace SpaceGame.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

