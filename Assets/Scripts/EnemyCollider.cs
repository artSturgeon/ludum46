using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{

    public int health = 10;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("enemy on collision enter: " + collision.collider.name);
        hitBy(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemy on trigger enter: " + other.name);
        hitBy(other);
    }


    private void hitBy(Collider other)
    {
        if (other.tag == "bullet")
        {
            health -= 5;
            if (health <= 0)
            {
                Debug.Log("enemy killed");
                gameObject.SetActive(false);
            }
        }
        else if (other.tag == "creature")
        {
            gameObject.SetActive(false);
        }
    }

}
