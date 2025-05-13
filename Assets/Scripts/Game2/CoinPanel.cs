using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text coins;
    private void Start()
    {
        coins.text = GameManager.Instance.PlayerCoins.ToString();

    }
    private void OnEnable()
    {
        GameManager.OnCoinUpdate += OnCoinUpdate;
    }
    private void OnDisable()
    {
        GameManager.OnCoinUpdate -= OnCoinUpdate;
    }
    public void OnCoinUpdate(int Coins)
    {
        coins.text = Coins.ToString();
    }
}
