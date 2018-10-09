using UnityEngine;
using System;
using UnityEngine.UI;

public class ClockAnimator : MonoBehaviour
{
    private const float
    hoursToDegrees = 360f / -12f,
    minutesToDegrees = 360f / -60f,
    secondsToDegrees = 360f / -60f;
    public Transform hours, minutes, seconds;
    public bool analog;

    void Start()
    {
        string TextOnClock;
        var dt =  DateTime.Now.DayOfWeek;
        TextOnClock = GameObject.Find("DayText").GetComponent<TextMesh>().text = dt.ToString();

        if (TextOnClock == "Tuesday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Tue";
        }
        if (TextOnClock == "Monday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Mon";
        }
        if (TextOnClock == "Wednesday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Wn";
        }
        if (TextOnClock == "Thursday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Thu";
        }
        if (TextOnClock == "Friday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Fr";
        }
        if (TextOnClock == "Saturday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Sat";
        }
        if (TextOnClock == "Sunday")
        {
            GameObject.Find("DayText").GetComponent<TextMesh>().text = "Sun";
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0));

        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hours.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
            minutes.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
            seconds.localRotation =
            Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
        }
    }
}