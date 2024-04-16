using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{   
    [SerializeField] Transform CameraHolder;
    float verticalLookRotation;
    float horizontalLookRotation;
    private float sensitivity;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        sensitivity = SettingsManager.instance.Sensor;

        horizontalLookRotation += Input.GetAxisRaw("Mouse X") * sensitivity;
        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * sensitivity;

        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        horizontalLookRotation = Mathf.Clamp(horizontalLookRotation, -90f, 90f);

        CameraHolder.localEulerAngles = new Vector3(verticalLookRotation, horizontalLookRotation, 0);
    }
}
