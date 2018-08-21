using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondArowRotait : MonoBehaviour {
    public GameObject midle;
    public GameObject Arrow;
    void Update()
    {
        transform.RotateAround(midle.transform.position, Vector3.back, 150 * Time.deltaTime);

        //RotateClock Sript1 = Arrow.GetComponent<RotateClock>();
        //Sript1.enabled = false;
    }
}
