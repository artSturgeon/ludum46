using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatureCollider : MonoBehaviour
{

    public int health = 5;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("creature collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("creature trigger");
        if (other.tag == "bullet")
        {
            Debug.Log("creature hit by bullet");
            Damage(5);
           
        }
        else if (other.tag == "enemy")
        {
            Debug.Log("creature hit by enemy");
            Damage(2);
        }
    }

    private void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Debug.Log("game over man");
            SceneManager.LoadScene(0);
        }
    }

}
