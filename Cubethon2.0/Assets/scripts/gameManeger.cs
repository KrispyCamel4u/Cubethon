using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class gameManeger : MonoBehaviour
{
    bool gameend = false;
    public GameObject completegameUI;
    public GameObject gmoverOb;
    public Button button;
    //public AudioManager manager;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   if(gmoverOb.activeSelf==true)
            restartbuttonpress();
            Debug.Log("activeiself");
        }
    }
    public void levelcomplete()
    {
        PlayerPrefs.SetInt("levelreached", SceneManager.GetActiveScene().buildIndex+1);
        completegameUI.SetActive(true);
        
    }
    public void endgame()
    {
        
        if (gameend==false)
        {
            gameend = true;
            Debug.Log("game over");
            Invoke("gameover",1.5f);
        }
        

    }
    public void gameover()
    {
        gmoverOb.SetActive(true);
        FindObjectOfType<AudioManager>().stop("theme");
        Invoke("playhit", 0.7f);
        Cursor.visible = true;
        
    }
    public void restart()
    {
        FindObjectOfType<AudioManager>().stop("waiting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<AudioManager>().play("theme");
        Cursor.visible = false;
    }
    void playhit()
    {
        Debug.Log("in playhit");
        FindObjectOfType<AudioManager>().play("waiting");
    }

    public void PrevLevel()
    {
        FindObjectOfType<AudioManager>().stop("waiting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        FindObjectOfType<AudioManager>().play("theme");
    }

    public void restartbuttonpress()
    {
        button.onClick.Invoke();
    }
}
