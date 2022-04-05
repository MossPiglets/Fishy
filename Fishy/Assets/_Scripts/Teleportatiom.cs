using System.Collections;
using UnityEngine;

namespace _Scripts {
    public class Teleportatiom : MonoBehaviour {
        [SerializeField] private Transform destination;
        void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Player")) {
                StartCoroutine(Teleport(other.transform.parent.transform));
            }
        }

        IEnumerator Teleport(Transform player) {
            yield return new WaitForSeconds(0);
            var position = destination.position;
            player.position = new Vector2(position.x, player.position.y);
        }
    }
}
