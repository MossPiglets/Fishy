using _Scripts;
using UnityEngine;

public class FishEnemy : FishBase {
    public float Speed = 2f;
    private Score score;
    private void Start() {
        score = GameObject.FindWithTag("Score").GetComponent<Score>();
        if (score == null) Debug.LogError("No Score object in the scene");
    }
    void Update() {
        transform.Translate(Time.deltaTime * Speed * Vector3.right);
    }

    protected override void OnFishEat(object sender, EatEventArgs args) {
        var otherFish = args.Fish;
        if (otherFish.CompareTag("Player")) {
            var playerFish = otherFish.GetComponent<PlayerFish>();
            if (playerFish.Size < this.Size) {
                playerFish.Die();
            }
        }
    }
}