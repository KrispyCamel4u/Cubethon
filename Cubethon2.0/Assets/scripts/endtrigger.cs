using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gameManeger manager;
    public Rigidbody player;
    void OnTriggerEnter()
    {
        Debug.Log("end Triggered");
        // player.constraints = RigidbodyConstraints.FreezePosition;
        //PlayerPrefs.SetFloat("score", FindObjectOfType<score>().number+1.5f);
        manager.levelcomplete();

    }
}
