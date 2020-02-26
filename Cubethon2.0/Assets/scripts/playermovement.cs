using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce;
    public float moveforce;
    public float x;
    //public gameManeger manager;
    public Touch thetouch;

    void Start()
    {
        int difficulty = PlayerPrefs.GetInt("difficultylevel", 0);
        if (difficulty == 0)
        {
            forwardforce = forwardforce-500;
        }
        else if (difficulty==1)
        {
            forwardforce = forwardforce - 250;
        }
        Debug.Log("forforce");
        Debug.Log(forwardforce);
    }
    void FixedUpdate()
    {
        //Debug.Log("again and again");
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            thetouch=Input.GetTouch(0);
            x = thetouch.position.x;
            
        }
        if (x > 0 || Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(moveforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (x < 0 || Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-moveforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ((rb.position.y < 0.0f) || (rb.position.x < -8.0f || rb.position.x > 8f))
        {
            Debug.Log("constraint");
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            FindObjectOfType<gameManeger>().endgame();
            //manager.endgame();
        }
        

    }
}
