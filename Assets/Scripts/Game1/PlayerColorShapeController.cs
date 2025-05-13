using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    [SerializeField] private ColorShapeData playerData;
    [SerializeField] private SpriteRenderer spriteRenderer;

    void OnEnable()
    {
        ColorObject.OnChangeColor += UpdateColor;
        ShapeObject.OnChangeShape += UpdateShape;
    }

    void OnDisable()
    {
        ColorObject.OnChangeColor -= UpdateColor;
        ShapeObject.OnChangeShape -= UpdateShape;
    }

    private void UpdateColor(Color newColor)
    {
        spriteRenderer.color = newColor;
        playerData.color = newColor;
    }

    private void UpdateShape(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
        playerData.shape = newSprite;
    }
}
