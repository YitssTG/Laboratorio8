using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{

    [SerializeField] private TMP_Text _life;

    private void Start()
    {
        _life.text = GameManager.Instance.PlayerLife.ToString();
    }

    public void OnLifeChange(int Life)
    {
        _life.text = Life.ToString();
    }
    private void OnEnable()
    {
        GameManager.OnLifeUpdate += OnLifeChange;
    }
    private void OnDisable()
    {
        GameManager.OnLifeUpdate -= OnLifeChange;
    }
}
