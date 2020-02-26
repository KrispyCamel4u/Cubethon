using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class Settings : MonoBehaviour
{
    public AudioManager Audio;
    public void Startgame()
    {
        //FindObjectOfType<AudioManager>().play("theme");
        FindObjectOfType<AudioManager>().stop("waiting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    
    public void setVolume(float volume)
    {
        string name = "theme";
        Debug.Log("");
        Sound s = Array.Find(Audio.sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("the sound" + name + "not found");
            return;
        }
        s.source.volume =volume;

    }
    public void setDifficulty(int difficultylevel)
    {
        PlayerPrefs.SetInt("difficultylevel", difficultylevel);
        //Debug.Log(PlayerPrefs.GetInt("difficultylevel"));
    }
    public void setquality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }
    
    public void setfullscreen(bool isfullscreen)
    {
        Debug.Log(isfullscreen);
        Screen.fullScreen = isfullscreen;
    }

    public void quit()
    {
        Debug.Log("quiting");
        Application.Quit();
    }
    
}
