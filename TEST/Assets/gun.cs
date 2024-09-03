using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;  
  
    public Transform firepoint;
    
    void Update()    
    {

      if(Input.GetKeyDown(KeyCode.Space))
       {
        Shoot();
       }


    }

     void Shoot()
        
    {

      Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
