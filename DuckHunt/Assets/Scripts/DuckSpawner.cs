using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    public GameObject duckprefab;
    public Transform[] duckSpawnPositions;
    private float duckSpeed;

    public float timeToSpawn = 2;




    private void Start()
    {
        StartCoroutine(SpawnCorrutine());

    }
        
    public IEnumerator SpawnCorrutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
              
            int rand = Random.Range(0, duckSpawnPositions.Length);
            Instantiate(duckprefab, duckSpawnPositions[rand].position, duckSpawnPositions[rand].rotation);
            transform.position += transform.forward * Time.deltaTime;
        }
    }
}