using UnityEngine;

namespace _Scripts {
    public class FishEnemy : FishBase {
        public float Speed = 2f;
        void Update() {
            transform.Translate(Time.deltaTime * Speed * Vector3.right);
        }

        protected override void OnFishEat(object sender, EatEventArgs args) {
            var otherFish = args.Fish;
            if (otherFish.CompareTag("Player")) {
                var playerFish = otherFish.GetComponent<PlayerFish>();
                if (playerFish.Size < this.Size) {
                    playerFish.Die();
                    this.Chomp.Play();
                }
            }
        }
    }
}