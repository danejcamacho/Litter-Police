using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemToSpawn;
    public GameObject enemyToSpawn;
    public float startDelayTrash = 1.0f;
    public float spawnIntervalTrash = 4;
    public float startDelayEnemy = 1.0f;
    public float spawnIntervalEnemy = 10;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomTrash", startDelayTrash, spawnIntervalTrash);
        InvokeRepeating("SpawnRandomEnemy", startDelayEnemy, spawnIntervalEnemy);
    }

    // Update is called once per frame
    void SpawnRandomTrash()
    {
        
        Vector2 randomSpawnPos = new Vector2(Random.Range(-10,11),Random.Range(-10,11));
        Instantiate(itemToSpawn, randomSpawnPos, Quaternion.identity);
        
    }

    void SpawnRandomEnemy(){
        Vector2 randomSpawnPos = new Vector2(Random.Range(-10,11),Random.Range(-10,11));
        Instantiate(enemyToSpawn, randomSpawnPos, Quaternion.identity);
    }
}
