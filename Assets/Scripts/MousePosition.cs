using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private Camera maincamera;
    [SerializeField] private LayerMask layerMask;
    void Update()
    {
        Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit,float.MaxValue,layerMask))
        {
            transform.position = Vector3.Slerp(transform.position, raycastHit.point, 0.5f);
            //transform.position = raycastHit.point;
        }
    }

    private void Move()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position,Time.deltaTime);
    }
}
