using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceGame.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject finishFireworks;
        [SerializeField] private GameObject finishLights;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player == null) return;

            if (collision.GetContact(0).normal.y == -1)
            {
                finishFireworks.gameObject.SetActive(true);
                finishLights.gameObject.SetActive(true);
            }
            else
            {
                //Game Over
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

