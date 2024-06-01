using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // List of possible spawn points
    public Transform spawnPoints;
    // Prefab of the egg to spawn
    public GameObject eggPrefab;
    // Delay in seconds before the egg spawns
    public float spawnDelay = 5f;

    void Start()
    {
        // Start the coroutine to spawn an egg after the specified delay
        StartCoroutine(SpawnEggAfterDelay(spawnDelay));
    }
    
    // Coroutine to spawn an egg after a delay
    IEnumerator SpawnEggAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Instantiate the egg at the chosen spawn point
        Instantiate(eggPrefab, spawnPoints.position, spawnPoints.rotation);
    }
}

     
