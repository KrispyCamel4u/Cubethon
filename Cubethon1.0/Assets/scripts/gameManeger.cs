using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManeger : MonoBehaviour
{
    bool gameend = false;
    public GameObject completegameUI;
    public GameObject gmoverOb;
    public void levelcomplete()
    {
        completegameUI.SetActive(true);
    }
    public void endgame()
    {
        //
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
    }
    public void restart()
    {
        FindObjectOfType<AudioManager>().stop("waiting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<AudioManager>().play("theme");
    }
    void playhit()
    {
        FindObjectOfType<AudioManager>().play("waiting");
    }
}
