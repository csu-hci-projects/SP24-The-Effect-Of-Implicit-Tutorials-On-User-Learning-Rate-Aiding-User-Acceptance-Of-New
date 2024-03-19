using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{

    public float rotateSpeed = 3.0F;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        transform.Rotate(Input.GetAxis("Vertical") * rotateSpeed, 0, 0);
    }
}
