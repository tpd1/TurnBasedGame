using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    private static MouseWorld instance;
    [SerializeField] private LayerMask mouseLayerMask;

    private void Awake()
    {
        instance = this;
    }

    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //returns true if hits collider.
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mouseLayerMask);
        return raycastHit.point;
    }
}