using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flask : MonoBehaviour
{
    public float delay = 2f;
   // public float blastRadius;

    float countdown;
    bool hasExploded =  false;

    public GameObject explosionEfx;
    
    void Start()
    {
        countdown = delay;
    }

   
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
        
    }

    void Explode()
{
    // Instantiate explosion effect
    GameObject explosion = Instantiate(explosionEfx, transform.position, transform.rotation);

    // Get nearby objects and apply force

    /*Collider[] colliders = Physics.OverlapSphere(transform.position , blastRadius);
    foreach (Collider nearbyObject in colliders)
    {
        //Add damage
    } */

    // Destroy the Flask
    Destroy(gameObject);

    // Destroy the explosion effect after 6 seconds
    Destroy(explosion, 6f);
}
    
}
