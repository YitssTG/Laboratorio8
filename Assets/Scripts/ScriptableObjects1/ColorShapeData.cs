using UnityEngine;


[CreateAssetMenu(fileName = "Color Shape Data", menuName = "Scriptable objects/Game 1/ColorShapeData")]
public class ColorShapeData : ScriptableObject
{
    [SerializeField] private Sprite _shape;

    [SerializeField] private Color _color;

    public Color Color => _color;
    public Sprite Sprite => _shape;
}
