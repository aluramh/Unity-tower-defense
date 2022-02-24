using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f,
        minutesToDegrees = -6f,
        secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot;

    [SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;

    void Awake()
    {
        Debug.Log("This just awoke!");
    }

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        Debug.Log(time.TotalHours);

        hoursPivot.localRotation = Quaternion.Euler(
            0f,
            0f,
            hoursToDegrees * (float)time.TotalHours
        );

        minutesPivot.localRotation = Quaternion.Euler(
            0f,
            0f,
            minutesToDegrees * (float)time.TotalMinutes
        );

        secondsPivot.localRotation = Quaternion.Euler(
            0f,
            0f,
            secondsToDegrees * (float)time.TotalSeconds
        );
    }
}
