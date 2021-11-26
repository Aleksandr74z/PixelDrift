using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverOverlay : MonoBehaviour
{
    [SerializeField] private Text _score;

    private void OnEnable()
    {
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void OnReplay()
    {
        var sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
