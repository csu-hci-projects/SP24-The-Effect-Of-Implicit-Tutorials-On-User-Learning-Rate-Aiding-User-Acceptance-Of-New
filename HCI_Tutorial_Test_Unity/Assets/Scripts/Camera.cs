using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; 
    public float distance = 5.0f; 
    public float rotationSpeed = 20.0f; 

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        transform.RotateAround(target.position, Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);

        transform.LookAt(target);
    }
}
