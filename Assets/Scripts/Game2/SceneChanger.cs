using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string sceneString;
    public void GoToMenu(string sceneString)
    {
        SceneManager.LoadScene(sceneString);
    }
    public void Scenes(string scene)
    {
        Time.timeScale = 1.0f;
        GameManager.Instance.ResetGame();
        SceneManager.LoadScene(scene);
    }
}

