using UnityEngine;

public class FishEnemy : FishBase {
    public float Speed = 2f;

    void Update() {
        transform.Translate(Time.deltaTime * Speed * Vector3.right);
    }
}