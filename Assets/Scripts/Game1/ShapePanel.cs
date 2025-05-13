using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    private Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    void OnEnable()
    {
        ShapeObjects.OnChangeShape += ChangeShape;
    }
    void OnDisable()
    {
        ShapeObjects.OnChangeShape -= ChangeShape;
    }
    public void ChangeShape(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
