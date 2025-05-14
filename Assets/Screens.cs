using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class Screens : MonoBehaviour
{
    [SerializeField] Image scrrenWin;
    [SerializeField] Image scrrenLose;

    private void OnEnable()
    {
        GameManager.OnWin += OnWin;
        GameManager.OnLoose += OnLose;
    }
    private void OnDisable()
    {
        GameManager.OnWin -= OnWin;
        GameManager.OnLoose -= OnLose;

    }
    public void OnWin()
    {
        Time.timeScale = 0f;
        scrrenWin.gameObject.SetActive(true);
    }
    public void OnLose()
    {
        Time.timeScale = 0f;
        scrrenLose.gameObject.SetActive(true);
    }
}
