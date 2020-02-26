using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("Quiting");
        Application.Quit();
    }
}
