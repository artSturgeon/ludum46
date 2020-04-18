using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public Transform playerBody;
    public CharacterController controller;
    public float speed = 12f;

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Vector3 move = transform.right * x + transform.forward * z;

        playerBody.Rotate(Vector3.up * x);

        Vector3 move = transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);

    }
}
