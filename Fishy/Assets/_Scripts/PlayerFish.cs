using UnityEngine;

namespace _Scripts {
    public class PlayerFish : FishBase {
        private Score _score;

        private void Start() {
            _score = GameObject.FindWithTag("Score")?.GetComponent<Score>();
            if (_score == null) Debug.LogError("Score game object not found in the scene");
        }

        public override void Die() {
            Debug.Log("Lose game");
            base.Die();
        }

        protected override void OnFishEat(object sender, EatEventArgs args) {
            var otherFish = args.Fish;
            if (otherFish.CompareTag("Enemy")) {
                var enemyFish = otherFish.GetComponent<FishEnemy>();
                if (enemyFish.Size < this.Size) {
                    enemyFish.Die();
                    _score.Add((int) Mathf.Pow(2, (float) this.Size));
                    if (Mathf.Log(_score.ScoreValue, 2) > (double)this.Size) {
                        SetSize(Size + 1);
                    }
                }
            }
        }
    }
}