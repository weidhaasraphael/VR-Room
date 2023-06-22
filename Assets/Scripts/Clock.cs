using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] GameObject hourHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject secondHand;

    // Start is called before the first frame update
    void Start()
    {
        //Update the clock every second
        InvokeRepeating("UpdateClock", 0, 1);
    }

    void UpdateClock()
    {
        float hourAngle = (DateTime.Now.Hour / 12f) * 360f + 90;
        float minuteAngle = (DateTime.Now.Minute / 60f) * 360f + 90;
        float secondAngle = (DateTime.Now.Second / 60f) * 360f + 90;

        //local rotation is relative to parent rotatoin
        //Quaternion are used to represent rotation
        //Euler = z --> x --> y rotation
        hourHand.transform.localRotation = Quaternion.Euler(hourAngle, 0, -90);
        minuteHand.transform.localRotation = Quaternion.Euler(minuteAngle, 0, -90);
        secondHand.transform.localRotation = Quaternion.Euler(secondAngle, 0, -90);
    }
}
