using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickOnButton : MonoBehaviour
{
    public AudioClip hitSound;
    public Database database;
    public GameObject arrow;
    public GameObject howerarrow;
    public GameObject minutearrow;
    public GameObject midle;
    public Transform hours, minutes, seconds;
    private const float
    hoursToDegrees = 360f / -12f,
    minutesToDegrees = 360f / -60f;
    public int index;

    void Awake()
    {
        if (!database)
        {
            database = Resources.Load("Database") as Database;
        }

        if (!arrow)
        {
            arrow = GameObject.Find("SecondArrow");
        }

        if (!howerarrow)
        {
            howerarrow = GameObject.Find("HowerArrow");
        }

        if (!minutearrow)
        {
            minutearrow = GameObject.Find("MinutArrow");
        }

        if (!midle)
        {
            midle = GameObject.Find("Second");
        }
    }

    void Start()
    {
        index = 1;
    }

    void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().clip = hitSound;
        gameObject.GetComponent<AudioSource>().Play();

        arrow.GetComponent<SpriteRenderer>().sprite = database.items[index].sprite;

        if (index < database.items.Length - 1)
        {
            index++;
        }
        else
        {
            index--;
        }

        //howerarrow.transform.RotateAround(midle.transform.position, Vector3.back, 450 * Time.deltaTime);
        //minutearrow.transform.RotateAround(midle.transform.position, Vector3.back, 300 * Time.deltaTime);
        DateTime time = DateTime.Now;
        hours.localRotation = Quaternion.Euler(300f, 300f, time.Hour * -hoursToDegrees);
        minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
    }
}
