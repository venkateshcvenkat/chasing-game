using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject Hummer;
    public AudioSource audiosource;
    public GameObject ui;
    public ParticleSystem effect;
    void Start()
    {
        ui.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hummer"))
        {
            ui.SetActive(true);
            Debug.Log("finish");
            Time.timeScale = 0;
            audiosource.enabled = false;
            effect.Play();
        }
    } 

}  
