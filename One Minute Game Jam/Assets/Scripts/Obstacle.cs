using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Debug.Log("GameOver");
        }
    }
}
