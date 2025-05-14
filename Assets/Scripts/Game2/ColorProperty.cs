using UnityEngine;

public class ColorProperty : MonoBehaviour
{
    [SerializeField] protected ColorData colorData;
    protected MeshRenderer meshRenderer;
    [SerializeField] protected Material material;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        SetUpColor(colorData);
    }
    protected void SetUpColor(ColorData newColor)
    {
        material.color = newColor.color;
        meshRenderer.material = material;
    }
}
