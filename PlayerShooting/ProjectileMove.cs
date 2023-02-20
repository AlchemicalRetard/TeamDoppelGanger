using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
   public float speed;

   void Update()
   {
    if(speed!=0)
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }
    else
    {
        Debug.Log("No Speed");
    }
   }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject); // Destroy the projectile as well
        }
    }
   
}
