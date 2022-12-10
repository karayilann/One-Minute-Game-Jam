using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roads : MonoBehaviour
{
    public float speed = 4f;
    Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -21.12f)
        {
            transform.position = StartPosition; 
        }
    }
}
