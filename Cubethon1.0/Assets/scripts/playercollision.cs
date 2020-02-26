using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;
    public void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().stop("theme");
            FindObjectOfType<AudioManager>().play("hit");
            FindObjectOfType<gameManeger>().endgame();
        }
    }

    

}
