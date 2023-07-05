using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePedestal : MonoBehaviour
{
    public Slider rotationSlider;
    private float angleSliderNumber;
    [SerializeField] float speed = 10.0f;

    void Update()
    {
        angleSliderNumber = rotationSlider.value * speed;
        this.transform.rotation = Quaternion.Euler(0, angleSliderNumber, 0);
    }
}