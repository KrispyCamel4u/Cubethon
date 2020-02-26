using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void Loadnextlevel()
    {
        Debug.Log("loading next level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (SceneManager.GetActiveScene().buildIndex + 1 == 4)
        {
            FindObjectOfType<AudioManager>().stop("theme");
            FindObjectOfType<AudioManager>().play("waiting");
            PlayerPrefs.DeleteAll();
        }
    }
    
}
