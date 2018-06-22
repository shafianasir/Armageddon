using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject listImage;

    private void Update()
    {
        //add button on screen
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                //PauseMenuUI.SetActive(false);
                Resume();
            }
            else
            {
                //PauseMenuUI.SetActive(true);
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
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

    public void List()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        listImage.SetActive(true);
    }

    public void Back()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        listImage.SetActive(false);
    }
}