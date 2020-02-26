using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelector : MonoBehaviour
{
    public Button[] levelButton;

    void Start()
    {
        Debug.Log("START");
        int levelreached = PlayerPrefs.GetInt("levelreached", 1);
        Debug.Log(levelreached);
      
        Time.timeScale = 1f;
        for (int i = levelreached; i < levelButton.Length; i++)
        {
            levelButton[i].interactable = false;
        }
        
    }
   
    public void SelectLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

   
}
