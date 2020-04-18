using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bullet collision enter");
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
        gameObject.SetActive(false);
    }

}
