using UnityEngine;

public class Teleport : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Collision");
        if (other.CompareTag("Player")) {
            var cameraPosition = Camera.main.rect;
            
            if (other.gameObject.transform.position.x < cameraPosition.xMin) {
                Debug.Log(cameraPosition.xMax);
                Debug.Log(cameraPosition.xMin);
                other.gameObject.transform.position = new Vector3(cameraPosition.xMax, other.gameObject.transform.position.y);
            }
            else if (other.gameObject.transform.position.x >= cameraPosition.xMax) {
                other.gameObject.transform.position = new Vector3(cameraPosition.xMin, other.gameObject.transform.position.y);
            }
        }
    }
}
