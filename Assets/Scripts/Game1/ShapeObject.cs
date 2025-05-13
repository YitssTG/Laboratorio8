using System;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    public static event Action<Sprite> OnChangeShape;
    public ColorShapeData shapeData;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && shapeData != null)
        {
            OnChangeShape?.Invoke(shapeData.shape);
        }
    }
}
