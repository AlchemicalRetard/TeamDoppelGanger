using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform gunBarrelTransform;
    public GameObject bulletPrefab;
    public float bulletVelocity = 10f;
    public float shootingInterval = 2f;

    public float bulletLife = 3f;
    
    private Transform playerTransform;
    private float timeSinceLastShot = 0f;

    private void Awake()
    {
        // Find the player object and get its transform
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Calculate the direction from the enemy to the player
        Vector3 playerDirection = playerTransform.position - gunBarrelTransform.position;
        playerDirection.y = 0f;
        playerDirection.Normalize();

        // Rotate the gun barrel towards the player
        gunBarrelTransform.rotation = Quaternion.LookRotation(playerDirection);

        // Check if it's time to shoot
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= shootingInterval)
        {
            // Reset the shooting timer
            timeSinceLastShot = 0f;

            // Spawn a bullet at the gun barrel's position and rotation
            GameObject bullet = Instantiate(bulletPrefab, gunBarrelTransform.position, gunBarrelTransform.rotation);

            // Add velocity to the bullet in the direction of the player
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = playerDirection * bulletVelocity;

            Destroy(bullet,bulletLife);
        }
    }

    
}
