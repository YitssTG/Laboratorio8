using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    private Image imageColor;
    void Awake()
    {
        imageColor = GetComponent<Image>();
    }
    void OnEnable()
    {
        ColorObject.OnChangeColor += ChangeColor;
    }
    void OnDisable()
    {
        ColorObject.OnChangeColor -= ChangeColor;
    }
    public void ChangeColor(Color color)
    {
        imageColor.color = color;
    }
}
