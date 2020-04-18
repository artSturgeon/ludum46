using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
    
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("fire");
            var clone = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }


    }
}
