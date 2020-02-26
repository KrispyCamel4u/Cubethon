using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameispause = false;
    public GameObject pausemenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispause)
            {
                Resume();
                Cursor.visible = false;
                Debug.Log("false visiblity");
            }
            else
            {
                Pause();
                Cursor.visible = true;
                Debug.Log("true visi");
            }
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispause = false;
    }
    public void Pause()
    {
        Debug.Log("in pause");
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispause = true;
    }

    public void mainmenu()
    {
         SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().play("theme");
        FindObjectOfType<AudioManager>().stop("waiting");
    }

    public void quit()
    {
        Application.Quit();
    }
}
