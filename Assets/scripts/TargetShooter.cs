using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject target = hit.collider.gameObject;

                if (target != null)
                {
                    target.GetComponent<TargetScritp>().Hit();
                    Console.WriteLine(1);

                    FindObjectOfType<canvasManager>().add_count();
                }
            }
            else
            {
                FindObjectOfType<canvasManager>().add_miss();
            }
        }
    }
}
