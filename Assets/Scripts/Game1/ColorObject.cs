using System;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    [SerializeField] private ColorShapeData dataColor;

     private SpriteRenderer _spriteRenderer;
    public static event Action<Color> OnChangeColor;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        ControllShapeColor();
    }
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.CompareTag("Player"))
        {
            OnChangeColor?.Invoke(_spriteRenderer.color);
        }
    }
    public void ControllShapeColor()
    {
        _spriteRenderer.color = dataColor.Color;
        _spriteRenderer.sprite = _spriteRenderer.sprite;
    }


}
