using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float health = 30f;
    public GameObject over;
  
    private void Start()
    {
        over.SetActive(false);
    }

    private void Update()
    {
        if(transform.position.y <= -20)
        {
            over.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Police"))
        {
            TakeDamge(10);
        }
    }



    public void TakeDamge(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            over.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
