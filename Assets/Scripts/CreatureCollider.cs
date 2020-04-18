using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCollider : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("creature collision");
    }

}
