using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [SerializeField] Transform CameraHolder;
    float verticalLookRotation;
    public float sensitivity;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;  
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * sensitivity);
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * sensitivity;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        CameraHolder.localEulerAngles = new Vector3(verticalLookRotation * sensitivity, 0, 0);
    }
}
