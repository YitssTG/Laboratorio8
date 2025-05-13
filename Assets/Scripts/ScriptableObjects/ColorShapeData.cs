using UnityEngine;


[CreateAssetMenu(fileName = "Color Shape Data", menuName = "Scriptable objects/Game 1/ColorShapeData")]
public class ColorShapeData : ScriptableObject
{
    public Color color = Color.white;
    public Sprite shape;
}
