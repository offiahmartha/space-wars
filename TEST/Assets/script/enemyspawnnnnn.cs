using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawnnnnn : MonoBehaviour
{
      public GameObject enemyPrefab;
    public float spawnInterval = 2f;   
    public float spawnXOffset = 10f;
    public float moveSpeed = 5f;
    public float minY =  -4f;      
    public float maxY = 4f;
    
    private float timeSinceLastSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
          // Track time and spawn enemies at regular intervals 
        timeSinceLastSpawn += Time.deltaTime;

        if(timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnEnemy()
    {
       float spawnY = Random.Range(minY, maxY);

       float spawnX = Camera.main.transform.position.x + spawnXOffset;

       Vector2 spawnPosition = new Vector2(spawnX, spawnY);

       GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

       Rigidbody2D enemyRb = enemy.GetComponent<Rigidbody2D>();
       if (enemyRb != null)
       {
           enemyRb.velocity = Vector2.left * moveSpeed;
       }
    }
}
