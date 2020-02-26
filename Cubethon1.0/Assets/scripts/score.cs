using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public Transform End;
    public float prev;
    public float number;

    public void Awake()
    {
        prev=PlayerPrefs.GetFloat("score", 0);
    }
    void Update()
    {
        if ((SceneManager.GetActiveScene().buildIndex > 0) && (player.position.z < End.position.z))
        {
            number = (player.position.z +prev);
            scoretext.text = number.ToString("0");
        }
       // scoretext.text=player
    }
}
