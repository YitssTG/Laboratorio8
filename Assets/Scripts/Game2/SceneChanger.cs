using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string sceneString;
    public void GoToMenu(string sceneString)
    {
        SceneManager.LoadScene(sceneString);
    }
}
