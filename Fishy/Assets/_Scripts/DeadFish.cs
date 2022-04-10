using System.Collections;
using UnityEngine;

namespace _Scripts {
    public class DeadFish : MonoBehaviour {
        void Awake() {
            StartCoroutine(Despawn());
        }

        public IEnumerator Despawn() {
            yield return new WaitForSeconds(5);
            Destroy(this.gameObject);
        }
    }
}