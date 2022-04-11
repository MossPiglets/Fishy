using _Scripts.FishSizes;
using UnityEngine;

namespace _Scripts {
    public class PlayerFish : FishBase {
        private Score _score;
        private GameObject _gameOver;

        private void Start() {
            _gameOver = GameObject.Find("GameOver");
            if (_gameOver == null) Debug.LogError("GameOver game object not found in the scene");
            _gameOver.SetActive(false);
            _score = GameObject.FindWithTag("Score")?.GetComponent<Score>();
            if (_score == null) Debug.LogError("Score game object not found in the scene");
        }

        public override void Die() {
            Debug.Log("Lose game");
            _gameOver.SetActive(true);
            base.Die();
        }

        protected override void OnFishEat(object sender, EatEventArgs args) {
            var otherFish = args.Fish;
            if (otherFish.CompareTag("Enemy")) {
                var enemyFish = otherFish.GetComponent<FishEnemy>();
                if (enemyFish.Size < this.Size) {
                    enemyFish.Die();
                    this.Chomp.Play();
                    _score.Add((int) Mathf.Pow(2, (float) enemyFish.Size));
                    if (Size != FishSize.Boss && Mathf.Log(_score.ScoreValue, 2) > (double)this.Size) {
                        SetSize(Size + 1);
                    }
                }
            }
        }
    }
}