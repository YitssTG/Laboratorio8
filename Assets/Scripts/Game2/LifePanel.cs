using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text life;
    private void OnEnable()
    {
        GameManager.OnLifeUpdate += OnLifeUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnLifeUpdate -= OnLifeUpdate;
    }
    private void Start()
    {
        life.text = GameManager.Instance.PlayerLife.ToString();
    }

    public void OnLifeUpdate(int Life)
    {
        life.text = Life.ToString();
    }
}
