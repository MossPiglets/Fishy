using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private Text scoreText;
    private int scoreValue;
    void Start() {
        scoreText = GetComponent<Text>();
        scoreValue = 0;
        scoreText.text = "0";
    }

    public void Add(int score) {
        scoreValue += score;
        scoreText.text = scoreValue.ToString();
    }
}
