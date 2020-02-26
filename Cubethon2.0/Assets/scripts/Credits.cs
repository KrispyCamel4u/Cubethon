using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
