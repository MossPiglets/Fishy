using UnityEngine;

namespace _Scripts {
    public class Teleportatiom : MonoBehaviour {
        [SerializeField] private Transform destination;
        void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Player")) {
                var player = other.transform.parent.transform;
                player.position = new Vector2(destination.position.x, player.position.y);
            }
        }
    }
}
