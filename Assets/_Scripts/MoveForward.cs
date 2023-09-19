using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    //Makes an object (bullet) move forward.
    void Update()
    {
        transform.Translate(0,0, speed*Time.deltaTime);
    }
}
