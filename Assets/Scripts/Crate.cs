using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    //AudioSource audioSource = null;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Debug.Log(collision.gameObject);
    }
}
