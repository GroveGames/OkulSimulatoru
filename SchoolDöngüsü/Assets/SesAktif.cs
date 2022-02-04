using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesAktif : MonoBehaviour
{
    public GameObject audiyo;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ses")
        {
            audiyo.SetActive(true);
        }
    }
}
