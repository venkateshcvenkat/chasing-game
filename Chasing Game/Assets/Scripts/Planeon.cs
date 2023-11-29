using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeon : MonoBehaviour
{
    public GameObject Plane;

    
    void Start()
    {
        Plane.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hummer"))
        {
            Plane.SetActive(true);
        }
    }
    
    
}
