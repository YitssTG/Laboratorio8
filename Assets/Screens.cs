using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class Screens : MonoBehaviour
{
    [SerializeField] Image GameWin;
    [SerializeField] Image GameLoose;

    private void OnEnable()
    {
        GameManager.OnWin += IfWin;
        GameManager.OnLoose += IfLoose;
    }
    private void OnDisable()
    {
        GameManager.OnWin -= IfWin;
        GameManager.OnLoose -= IfLoose;

    }
    public void IfWin()
    {
        Time.timeScale = 0f;
        GameWin.gameObject.SetActive(true);
    }
    public void IfLoose()
    {
        Time.timeScale = 0f;
        GameLoose.gameObject.SetActive(true);
    }
}
