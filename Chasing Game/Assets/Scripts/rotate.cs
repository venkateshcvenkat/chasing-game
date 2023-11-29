using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject Gate;
    public GameObject hummer;
    public GameObject hint;
    void Start()
    {
        Gate.SetActive(false);
        hint.SetActive(true);
     
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hummer"))
        {
            Debug.Log("enter");
            Gate.SetActive(true);
         
            Debug.Log("Gameover");
            hummer.transform.parent = this.transform;
            hint.SetActive(false);
        }
    }
    
}
