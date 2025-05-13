using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private ColorShapeData dataCharacter;

    private void Awake()
    {
        _spriteRenderer = GetComponent <SpriteRenderer>();
    }
    void Start()
    {
        ControllShapeColor();
    }
    public void ControllShapeColor()
    {
        _spriteRenderer.color =  dataCharacter.Color;
        _spriteRenderer.sprite = dataCharacter.Sprite;
    }
    public void ChangeShape(Sprite sprite)
    {
        _spriteRenderer.sprite = sprite;
    }
    public void ChangeColor(Color color)
    {
        _spriteRenderer.color = color ;
    }
    void OnEnable()
    {
        ShapeObjects.OnChangeShape += ChangeShape;

        ColorObject.OnChangeColor += ChangeColor;
    }
    void OnDisable()
    {
        ShapeObjects.OnChangeShape -= ChangeShape;
        ColorObject.OnChangeColor -= ChangeColor;
    }
}
