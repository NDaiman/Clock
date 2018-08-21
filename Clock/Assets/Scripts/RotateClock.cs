using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClock : MonoBehaviour {
    public GameObject Arrow;
    public GameObject midle;

    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0));
    }
}
