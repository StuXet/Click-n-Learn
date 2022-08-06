using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        //Pause menu appears or gone when "esc" button was clicked
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //Currently load scene 1 again because we have 1 level, in the future with more level this code needs to be rewritten
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}

