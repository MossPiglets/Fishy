using UnityEngine;

public class FishEnemy : MonoBehaviour {
    public float Speed = 2f;

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}
