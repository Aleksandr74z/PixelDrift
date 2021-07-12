using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGames : MonoBehaviour
{
        
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGames()
    {
        Application.Quit();
    }
        
}
