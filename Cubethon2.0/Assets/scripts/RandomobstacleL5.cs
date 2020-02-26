using UnityEngine;

public class RandomobstacleL5 : MonoBehaviour
{
    public Transform[] obstacles;
    public Vector3 pos1;

    public Transform[] o1;
    public Rigidbody[] rb1;

    public Vector3 pos;
    int [] dir= { 0, 0 };
    int[] dir2 = { 0, 0 };
    void Start()
    {
        pos.y = 1f;
        for (int i = 0; i < o1.Length; i++)
        {
            
            pos.x = Random.Range(-6.5f, 6.5f);
            pos.z = o1[i].position.z;
            o1[i].position = pos;

        }
        for (int i = 0; i < obstacles.Length; i++)
        {
            pos1.x = Random.Range(-6.5f, 6.5f);
            pos1.y = 1f;
            pos1.z = Random.Range(249f, 275f);

            obstacles[i].position = pos1;

        }

    }

    void FixedUpdate()
    {
        //Debug.Log("again");
        for (int i = 0; i < rb1.Length; i++)
        {
            //Debug.Log("force");
            
            if (rb1[i].position.x <= -1.5f) {
                dir[i] = 0;
            }
            else if (rb1[i].position.x >= 1.5f)
            {
                dir[i] = 1;
            }
           // Debug.Log(Mathf.Pow(-1, dir[i]) * 30 * Time.deltaTime);
            rb1[i].AddForce(Mathf.Pow(-1,dir[i])*20 * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
       
    }

}
