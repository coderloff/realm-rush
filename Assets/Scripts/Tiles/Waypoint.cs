using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    [SerializeField] GameObject towerPrefab;

    public bool IsPlacable { get { return isPlacable; } }

    void OnMouseDown()
    {
        if (isPlacable)
        {
            GameObject tower = Instantiate(towerPrefab, transform.position, Quaternion.identity);
            // tower.transform.parent = transform;
            isPlacable = false;
        }
    }
}
