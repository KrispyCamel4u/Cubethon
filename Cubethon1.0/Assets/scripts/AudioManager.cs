using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Sound[] sounds;
    public static AudioManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    private void Start()
    {
        play("theme");
        PlayerPrefs.DeleteAll();
    }
    public void play(string name)
    {
        Sound s=Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("the sound" + name + "not found");
            return;
        }
        s.source.Play();
    }
    public void stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("the sound" + name + "not found");
            return;
        }
        s.source.Stop();
    }
}
