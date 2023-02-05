using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedScreenScript : MonoBehaviour
{
    public static bool paused;
    public GameObject pauseMenu;

    public void Retart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void setPauseMenu(bool isPaused)
    {
        paused = isPaused;

        Time.timeScale = (paused) ? 0 : 1;
        pauseMenu.SetActive(paused);
    }

    void Start()
    {
        setPauseMenu(false);    
    }
}
