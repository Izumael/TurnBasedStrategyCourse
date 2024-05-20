using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisualSingle : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;

    public void Show(Material material)
    {
        this.meshRenderer.enabled = true;
        meshRenderer.material = material;
    }

    public void Hide()
    {
        this.meshRenderer.enabled = false;
    }
}
