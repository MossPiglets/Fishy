using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    public int ScoreValue => _scoreValue;
    private int _scoreValue;
    void Start() {
        scoreText.text = "0";
    }

    public void Add(int score) {
        _scoreValue += score;
        scoreText.text = _scoreValue.ToString();
    }
}
