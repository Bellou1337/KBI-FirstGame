using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] canvasManager canvasManager;
    public AudioSource source;
    public int volume = 100;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out RaycastHit hit, 100))
            {
                GameObject target = hit.collider.gameObject;

                if (hit.collider.tag == "Target")
                {
                    target.GetComponent<TargetScript>().Hit();
                    canvasManager.add_count();
                }
                else
                {
                    canvasManager.add_miss();
                }
            }
            source.volume = (float) volume / 100;
            source.Play();

        }
    }
}
