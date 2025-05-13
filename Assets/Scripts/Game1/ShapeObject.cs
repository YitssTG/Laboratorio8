using System;
using UnityEngine;

public class ShapeObjects : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private ColorShapeData dataShape;
    public static event Action<Sprite> OnChangeShape;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnChangeShape?.Invoke(_spriteRenderer.sprite);
        }
    }
    public void ControllShapeColor()
    {
        _spriteRenderer.color = dataShape.Color;
        _spriteRenderer.sprite = dataShape.Sprite;
    }

}
