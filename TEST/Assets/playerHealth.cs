using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    [SerializeField] private int currentHealth;


    void Start()
    {

        currentHealth = maxHealth;  
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
            GameOver();
        }
    }

    void Die()
    {

        Debug.Log("Player Died");
        Destroy(gameObject);
    } 

private void OnTriggerEnter2D(Collider2D collision)
{
 EnemyBullet bullet = collision.GetComponent<EnemyBullet>();
    if(bullet != null && bullet.isEnemy)
    {
         TakeDamage(1);

         Destroy(bullet.gameObject);
    }
}

    void GameOver()
    {
     Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.CompareTag("Enemy"))
        {
              Die();
            GameOver();
        }

    }
}
    




















