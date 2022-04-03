using UnityEngine;
using UnityEngine.UI;

namespace _Scripts {
    public class Score : MonoBehaviour {
        public Text scoreText;
        public int ScoreValue => scoreValue;
        [SerializeField] private int scoreValue;
        void Start() {
            scoreText.text = scoreValue.ToString();
        }

        public void Add(int score) {
            scoreValue += score;
            scoreText.text = scoreValue.ToString();
        }
    }
}
