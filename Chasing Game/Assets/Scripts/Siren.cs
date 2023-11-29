using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren : MonoBehaviour
{
    public GameObject Redlight, Bluelight;
    public float waittime = .2f;
    void Start()
    {
        StartCoroutine(siren());
    }

   IEnumerator siren()
    {
        yield return new WaitForSeconds(waittime);
        Redlight.SetActive(false);
        Bluelight.SetActive(true);
        yield return new WaitForSeconds(waittime);
        Redlight.SetActive(true);
        Bluelight.SetActive(false);
        StartCoroutine(siren());
    }
}
