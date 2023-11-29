using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    public float speed = 100;
    void Start()
    {
        
    }

 
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
