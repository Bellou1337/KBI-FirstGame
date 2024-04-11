using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBouns : MonoBehaviour
{
    public static TargetBouns Instance;

    private void Awake()
    {
        Instance = this;
    }

    [SerializeField] BoxCollider box;

    public Vector3 GetRandomPosition()
    {
        Vector3 center = box.center + transform.position;

        float minX = center.x - box.size.x / 2f;
        float maxX = center.x + box.size.x / 2f;

        float minY = center.y - box.size.y / 2f;
        float maxY = center.y + box.size.y / 2f;

        float minZ = center.z - box.size.z / 2f;
        float maxZ = center.z + box.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 RandPos = new Vector3(randomX, randomY, randomZ);

        return RandPos;
    }
}
