using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] public int PlayerLife;
    [SerializeField] public int PlayerCoins;
    public static event Action<int> OnLifeUpdate;
    public static event Action<int> OnCoinUpdate;
    public static event Action OnWin;
    public static event Action OnLoose;
    private int maxLife;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        Time.timeScale = 1.0f;
    }
    private void Start()
    {
        maxLife = PlayerLife;
    }
    private void Update()
    {
        ValidateLife();
    }
    public void GainCoin()
    {
        PlayerCoins++;
        OnCoinUpdate?.Invoke(PlayerCoins);

    }
    public void ModifyLife(int Modify)
    {
        PlayerLife = PlayerLife + Modify;
        OnLifeUpdate?.Invoke(PlayerLife);
    }
    public void CheckWin()
    {
        OnWin?.Invoke();
    }
    private void ValidateLife()
    {
        if (PlayerLife <= 0)
        {
            OnLoose?.Invoke();
        }
    }
    public void ResetGame()
    {
        PlayerLife = maxLife;
        PlayerCoins = 0;
    }
}
