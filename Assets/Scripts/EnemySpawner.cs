using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<Transform> spawnPoints;
    public float timeBetween;
    public GameObject enemy;
    public Transform enemyTarget;

    private float countdown;

    private void Start()
    {
        Debug.Log("spawner start");
        countdown = timeBetween;
    }

    private void Update()
    {
        countdown -= Time.deltaTime;
        
        if (countdown <= 0)
        {
            Debug.Log("spawning enemy");
            countdown = timeBetween;
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
            GameObject newEnemy = Instantiate(enemy,spawnPoint.position, spawnPoint.rotation);
            EnemyController controller = newEnemy.GetComponent<EnemyController>();
            controller.creature = enemyTarget;
        }
    }

    private void SpawnEnemy()
    {

    }

}
