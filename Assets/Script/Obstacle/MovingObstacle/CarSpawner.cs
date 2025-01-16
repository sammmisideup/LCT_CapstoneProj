using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    //[SerializeField] public GameObject[] obstaclePrefabs;
    [SerializeField] public GameObject carPrefabs;
    public Transform spawnPoints;
    // public float obstacleSpawnTime = 2f;
    public float obstacleSpeed = 1f;

    // private float timeUntilObstacleSpawn;

    // Update is called once per frame
    private void Update()
    {
        // SpawnLoop();
        
    }

    private  void SpawnLoop()
    {
        // timeUntilObstacleSpawn += Time.deltaTime;

        // if (timeUntilObstacleSpawn >= obstacleSpawnTime) 
        // {
        //     Spawn();
        //     timeUntilObstacleSpawn = 0f;
        // }
    }
    private void OnTriggerEnter(Collider col)
    {
        GameObject whatHit = col.gameObject;
        if(col.gameObject.tag == "Player")
        {
            Spawn();
        }
    }

    private void Spawn() 
    {
        // GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

        GameObject spawnedObstacle = Instantiate(carPrefabs, spawnPoints.position, Quaternion.identity);

        // Rigidbody obstacleRB = spawnedObstacle.GetComponent<Rigidbody>();
        
    }
}
