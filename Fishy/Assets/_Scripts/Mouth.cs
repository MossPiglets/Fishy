using System;
using UnityEngine;

namespace _Scripts {
    public class Mouth : MonoBehaviour {
        public event EventHandler<EatEventArgs> Eaten;

        private void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag("Enemy") || other.CompareTag("Player")) { 
               Eaten?.Invoke(this, new EatEventArgs() {Fish = other.gameObject});
            }
        }
    }

    public class EatEventArgs : EventArgs {
        public GameObject Fish { get; set; }
    }
}