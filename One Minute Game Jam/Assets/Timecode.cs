using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecode : MonoBehaviour
{
    private float sayac;
    private Slider zaman;

    private void Awake()
    {
        zaman = GameObject.Find("Slider").GetComponent<Slider>();

    }

    // Start is called before the first frame update
    void Start()
    {
        zaman.maxValue = 60;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        sayac = zaman.value;

    }

    // Update is called once per frame
    void Update()
    {
        if(zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;

        }
    }
}
