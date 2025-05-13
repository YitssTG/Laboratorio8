using UnityEngine;
using UnityEngine.SceneManagement;   
public class ChangeScene : MonoBehaviour
{
    public string SceneName;

    public void GoToMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GoToGame1(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego.... :c");
    }
}
