using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemToSpawn;
    public float startDelay = 1.0f;
    public float spawnInterval = 4;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomTrash", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomTrash()
    {
        
        Vector2 randomSpawnPos = new Vector2(Random.Range(-10,11),Random.Range(-10,11));
        Instantiate(itemToSpawn, randomSpawnPos, Quaternion.identity);
        
    }
}
