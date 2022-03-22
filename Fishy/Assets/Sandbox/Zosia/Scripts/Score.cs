using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    private int scoreValue;
    void Start() {
        scoreText.text = "0";
    }

    public void Add(int score) {
        scoreValue += score;
        scoreText.text = scoreValue.ToString();
    }
}
