using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int health = 1; 

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Playerbullet"))
        {
             TakeDamage(1);


              Destroy(other.gameObject);

        }
    }
    void TakeDamage(int damage)
    {
        health -= damage;


        if (health <= 0)
        {
            Die();  
        }    
    
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
    

         if(collision.gameObject.CompareTag("Player"))
          {
             Die();
          }
    }

     void Die()
     {

         Destroy(gameObject);
     }

}






    
         


























