using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnButton : MonoBehaviour
{
    public AudioClip hitSound;
    public Database database;
    public GameObject arrow;
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
    }
}
