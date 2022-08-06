using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject winnerMenuUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pause();
        }
    }

    void Pause()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        winnerMenuUI.SetActive(true);
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
