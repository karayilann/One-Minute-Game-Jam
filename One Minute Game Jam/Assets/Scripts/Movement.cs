using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject Car;
    [SerializeField] float SlipingRepeat;
    [SerializeField] float SlipingLeftRotation;
    [SerializeField] float SlipingRightRotation;
    [SerializeField] float ConrolRight;
    [SerializeField] float ConrolLeft;
    [SerializeField] float rot;
    [SerializeField] float speed;
    private void Awake()
    {
        rot = 1f;
    }
    void Start()
    {
        InvokeRepeating("SlipingCar", 1, SlipingRepeat);
     
    }
    private void Update()
    {
        DriveCar();
    }

    void DriveCar()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Car.transform.Rotate(0f, 0f, ConrolRight);
            rot += ConrolRight;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Car.transform.Rotate(0f, 0f, ConrolLeft);
            rot += ConrolLeft;
        }
    }
    void SlipingCar()
    {
        if (rot >= 0f)
        {
            Car.transform.Rotate(0f, 0f, SlipingLeftRotation);
            rot += SlipingLeftRotation;
        }

        if(rot <= 0f)
        {
            Car.transform.Rotate(0f, 0f, SlipingRightRotation);
            rot += SlipingRightRotation;
        }
 
    }

}
