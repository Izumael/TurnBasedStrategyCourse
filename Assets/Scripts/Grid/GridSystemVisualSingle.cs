using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisualSingle : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;

    public void Show()
    {
        this.meshRenderer.enabled = true;
    }

    public void Hide()
    {
        this.meshRenderer.enabled = false;
    }
}
