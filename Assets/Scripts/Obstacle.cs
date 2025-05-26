using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    public float obstacleGapYRange = 5.5f;
    public float obstacleOffsetY = 0f;

    private float timer = 0f;

    public float moveSpeed = 2f;
    public float destroyX = -15f;
    private List<GameObject> activeObstacles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnObstacle();
            timer = 0f;
            
        }
        HandleMovementAndCleanup();
    }

    
    void SpawnObstacle()
    {
        float y = Random.Range(-obstacleGapYRange, obstacleGapYRange) + obstacleOffsetY;
        Vector3 spawnPosition = new Vector3(10f, 0f, 0f); 
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        activeObstacles.Add(obstacle);

    }

    void HandleMovementAndCleanup()
    {
        for (int i = activeObstacles.Count - 1; i >= 0; i--)
        {
            GameObject obstacle = activeObstacles[i];
            if (obstacle == null)
            {
                activeObstacles.RemoveAt(i);
                continue;
            }

            obstacle.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Debug.Log("Moving obstacle: " + obstacle.name + " X: " + obstacle.transform.position.x);


            if (obstacle.transform.position.x < destroyX)
            {
                Destroy(obstacle);
                activeObstacles.RemoveAt(i);
            }
        }
    }
}
