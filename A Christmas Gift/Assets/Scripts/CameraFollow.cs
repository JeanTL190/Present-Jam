using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float smoothSpeed = 0.125f;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }
    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = SmoothedPosition;

    }
}
