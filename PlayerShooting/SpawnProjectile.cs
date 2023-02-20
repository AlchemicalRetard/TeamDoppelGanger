using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
   public GameObject firePoint;
   public List<GameObject> vfx = new List<GameObject>();

   public float fireRate = 0.5f;
   private float lastShotTime = 0f;

   private GameObject effectToSpawn;

   void Start()
   {
    effectToSpawn = vfx[0];
   }


   void Update()
   {
    if(Input.GetButton("Fire1") && Time.time > lastShotTime + fireRate)
    {
        SpawnVFX();
        lastShotTime = Time.time;
    }
   }

   void SpawnVFX()
   {
    GameObject vfx;

    if(firePoint!= null)
    {
        vfx = Instantiate(effectToSpawn , firePoint.transform.position , firePoint.transform.rotation);
    }
    else
    {
        Debug.Log("no firepoint");
    }
   }

}
