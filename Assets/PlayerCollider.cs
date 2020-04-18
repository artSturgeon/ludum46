using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("player collider");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player trigger");
    }
}
