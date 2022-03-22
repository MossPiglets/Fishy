using UnityEngine;

public class FishEnemy : MonoBehaviour {
    public float Speed = 2f;

    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.right);
    }
}
