using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockClic : MonoBehaviour
{
    public GameObject Sphere;
    public AudioClip hitSound;
    void OnMouseDown()
    {
        Debug.Log("Clock button pressed");
        gameObject.GetComponent<AudioSource>().clip = hitSound;
        gameObject.GetComponent<AudioSource>().Play();
        

        Instantiate(Sphere = GameObject.Find("Coin"), transform.position, transform.rotation);
    }
}