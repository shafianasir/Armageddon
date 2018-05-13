using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    private void Update()
    {
        //add button on screen
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                PauseMenuUI.SetActive(false);
                Resume();
            }
            else
            {
                PauseMenuUI.SetActive(true);
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting...");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}
