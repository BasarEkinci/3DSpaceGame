using SpaceGame.Managers;
using UnityEngine;

namespace SpaceGame.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject finishFireworks;
        [SerializeField] private GameObject finishLights;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;

            if (collision.GetContact(0).normal.y == -1)
            {
                finishFireworks.gameObject.SetActive(true);
                finishLights.gameObject.SetActive(true);
                SoundManager.Instance.PlaySound(5);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //Game Over
                GameManager.Instance.GameOver();
            }
        }
    }
}

