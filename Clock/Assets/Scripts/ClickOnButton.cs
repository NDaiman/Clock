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

        howerarrow.transform.RotateAround(midle.transform.position, Vector3.back, 450 * Time.deltaTime);
        minutearrow.transform.RotateAround(midle.transform.position, Vector3.back, 300 * Time.deltaTime);

        string TextOnClock;
        TextOnClock = GameObject.Find("DayText").GetComponent<TextMesh>().text;

        if (TextOnClock == "Tue")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Вт";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Tue";
        }

        if (TextOnClock == "Mon")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Пн";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Mon";
        }

        if (TextOnClock == "Wn")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Ср";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Wn";
        }

        if (TextOnClock == "Thu")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Чт";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Thu";
        }

        if (TextOnClock == "Fr")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Пт";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Fr";
        }

        if (TextOnClock == "Sat")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Ср";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Sat";
        }

        if (TextOnClock == "Sun")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Вс";
        }
        else
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Sun";
        }
    }
}
