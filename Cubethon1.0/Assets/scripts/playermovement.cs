using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000;
    public float moveforce=500;
    //public gameManeger manager;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
       // Debug.Log(rb.position);
        if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(moveforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-moveforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if ((rb.position.y < 0.0f)||(rb.position.x < -8.0f || rb.position.x > 8f))
        {
            Debug.Log("constraint");
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            FindObjectOfType<gameManeger>().endgame();
            //manager.endgame();
        }
        
    }
}
