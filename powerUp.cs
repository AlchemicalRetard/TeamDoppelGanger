using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    int collisionCount = 0;
    float powerUpSpeed=0f;
    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
    }
    // Update is called once per frame
    void Update()
    {
        if (collisionCount > 10)
        {
            powerUpSpeed = GetComponent<playerMove>().walkSpeed;
            GetComponent<playerMove>().walkSpeed = powerUpSpeed * 2;

        }
                
    }
}
