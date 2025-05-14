using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    [SerializeField] protected ColorData _colorData;
    protected MeshRenderer meshRenderer;

    [SerializeField] protected Material _material;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        SetUpColor(_colorData);
    }
    protected void SetUpColor(ColorData newColor)
    {
        _material.color = newColor.color;
        meshRenderer.material = _material;
    }
}
