using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 0.5f;
    [SerializeField] float maxSpawnDelay = 2f;
    [SerializeField] GameObject obstacle;

    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnObstacle();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
