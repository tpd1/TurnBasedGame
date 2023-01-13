using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    

    private void Update()
    {
        var stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            var moveSpeed = 4f;
            transform.position += Time.deltaTime * moveSpeed * moveDirection;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }

    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}