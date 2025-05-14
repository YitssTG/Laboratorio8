using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorPowerUpManager : MonoBehaviour
{
    [SerializeField] private ColorData[] colors;
    [SerializeField] private ColorData currentColor;
    [SerializeField] private bool canChangeColor;
    public static event Action<ColorData> OnChangeColor;
    public int currentcolor;
    private void OnEnable()
    {
        Enemy.OnEnter += ValdateCollision;
        Enemy.OnExit += ReturnToNormal;
    }
    private void OnDisable()
    {
        Enemy.OnEnter -= ValdateCollision;
        Enemy.OnExit -= ReturnToNormal;
    }
    public void OnPreviusColor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentcolor <= 0)
                {
                    currentcolor = colors.Length - 1;
                }
                else
                {
                    currentcolor--;
                }
                ChangeColorSelection();
                OnChangeColor?.Invoke(currentColor);
            }
        }
    }
    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            if (canChangeColor)
            {
                if (currentcolor >= colors.Length - 1)
                {
                    currentcolor = 0;
                }
                else
                {
                    currentcolor++;
                }
                ChangeColorSelection();
                OnChangeColor?.Invoke(currentColor);
            }
        }

    }
    public void ChangeColorSelection()
    {
        currentColor = colors[currentcolor];
    }
    private void ValdateCollision(ColorData otherColor, int damage)
    {
        canChangeColor = false;
        if (otherColor.color != currentColor.color)
        {
            GameManager.Instance.ModifyLife(damage);
        }
        else
        {
            Debug.Log("color");
        }
    }
    private void ReturnToNormal()
    {
        canChangeColor = true;

    }
}
