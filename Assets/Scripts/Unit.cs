using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;

    private void Update()
    {
        Vector3 moveDirection = (targetPosition - transform.position).normalized;
        float moveSpeed = 4f;
        if (Vector3.Distance(transform.position, targetPosition) >= Time.deltaTime * moveSpeed)
        {       
            transform.position += moveDirection * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move(new Vector3(4,4,4));
        }
    }

    private void Move(Vector3 targetPosition)
    {
        
        this.targetPosition = targetPosition;
    }

}
