using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessBackground : MonoBehaviour
{
    [SerializeField] float BackgroundSpeed;
    public Renderer Background;
    // Update is called once per frame
    void Update()
    {
        Background.material.mainTextureOffset += new Vector2(0, BackgroundSpeed);
    }
}
