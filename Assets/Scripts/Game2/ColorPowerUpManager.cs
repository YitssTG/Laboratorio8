using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;


public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] _arrayColors;
    [SerializeField] private ColorData _currentColor;

    [SerializeField] private bool canChangeColor;

    public static event Action<ColorData> OnChangeColor;
    public int currentcolor;

    public void OnPreviusColor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentcolor <= 0)
                {
                    currentcolor = _arrayColors.Length - 1;
                }
                else
                {
                    currentcolor--;
                }
                ChangeColor();
                OnChangeColor?.Invoke(_currentColor);
            }
        }
    }
    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentcolor >= _arrayColors.Length - 1)
                {
                    currentcolor = 0;
                } else
                {
                    currentcolor++;
                }
                ChangeColor();
                OnChangeColor?.Invoke(_currentColor);
            }
        }
    }
    public void ChangeColor()
    {
        _currentColor = _arrayColors[currentcolor];
    }
    private void ValdateCollision(ColorData otherColor, int damage)
    {
        canChangeColor = false;
        if (otherColor.color != _currentColor.color)
        {
            GameManager.Instance.ModifyLife(damage);
        }else
        {
            Debug.Log("Colisiona con un color... no pasa nada :c");
        }
    }
    private void ResetNormal()
    {
        canChangeColor = true;

    }
    private void OnEnable()
    {
        Enemy.OnEnter += ValdateCollision;
        Enemy.OnExit += ResetNormal;
    }
    private void OnDisable()
    {
        Enemy.OnEnter -= ValdateCollision;
        Enemy.OnExit -= ResetNormal;
    }
}
