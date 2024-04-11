using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public void Hit()
    {
        transform.position = TargetBouns.Instance.GetRandomPosition();
    }
}
