using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSphere : MonoBehaviour, IInteractable
{
    [SerializeField] private Material greenMaterial;
    [SerializeField] private Material redMaterial;
    [SerializeField] private MeshRenderer meshRenderer;
    private GridPosition gridPosition;
    private bool isGreen;
    private Action onInteractionComplete;
    private float timer;
    private bool isActive;

    private void Start()
    {
        gridPosition = LevelGrid.Instance.GetGridPosition(transform.position);
        LevelGrid.Instance.SetInteractableAtGridPosition(gridPosition, this);
        SetColorGreen();
    }

    private void Update()
    {
        if (!isActive)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            isActive = false;
            onInteractionComplete();
        }
    }


    private void SetColorRed()
    {
        isGreen = false;
        meshRenderer.material = redMaterial;
    }

    private void SetColorGreen()
    {
        isGreen = true;
        meshRenderer.material = greenMaterial;
    }

    public void Interact(Action onInteractionComplete)
    {
        this.onInteractionComplete = onInteractionComplete;
        isActive = true;
        timer = 0.5f;
        if (isGreen)
        {
            SetColorRed();
        }
        else
        {
            SetColorGreen();
        }
    }
}
