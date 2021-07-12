using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {            
            CallMenu();            
        }    
    }
    public void CallMenu()
    {
        if (_pauseMenu.activeInHierarchy)
        {
            _pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else 
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
