using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    public static event Action<Color> OnChangeColor;
    public ColorShapeData colorData;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && colorData != null)
        {
            OnChangeColor?.Invoke(colorData.color);
        }
    }
}
