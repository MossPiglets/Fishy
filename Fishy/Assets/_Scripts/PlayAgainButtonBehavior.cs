using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButtonBehavior : MonoBehaviour
{    public void OnClick() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
