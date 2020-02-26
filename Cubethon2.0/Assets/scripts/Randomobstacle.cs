using UnityEngine;

public class Randomobstacle : MonoBehaviour
{
    public Transform[] obstacles;
    public Vector3 pos;
    void Start()
    {
         for (int i = 0; i < obstacles.Length; i++)
         {
            pos.x = Random.Range(-6.5f, 6.5f);
            pos.y = 1f;
            pos.z=Random.Range(230f, 250f);

            obstacles[i].position = pos;
                
         }
        
    }

}
