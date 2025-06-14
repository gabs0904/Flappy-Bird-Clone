using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public ObstaclePair obstaclePairPrefab;
    public float spawnRate = 2f;
    public float minHeight = -1f;
    public float maxHeight = 2f;
    public float gap = 3f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn)); 
    }
  
    private void Spawn()
    {
        float y = Random.Range(minHeight, maxHeight);
        Vector3 spawnPosition = new Vector3(10f, y, 0f); 
        ObstaclePair pair = Instantiate(obstaclePairPrefab, spawnPosition, Quaternion.identity);

        //pair.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        pair.gap = gap;
    }
}