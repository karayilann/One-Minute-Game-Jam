using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCodes : MonoBehaviour
{
     float sayac;
     Slider zaman;

    void Awake()
    {
        zaman = GameObject.Find("Timer").GetComponent<Slider>();

    }

    // Start is called before the first frame update
    void Start()
    {
        zaman.maxValue = 60;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        zaman.value = zaman.maxValue;
        sayac = zaman.value;
    }

    // Update is called once per frame
    void Update()
    {

        if (zaman.value > zaman.minValue)
        {
            zaman.value -= Time.deltaTime;
            zaman.value = sayac;
        }

    }
}


