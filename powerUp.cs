using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    [SerializeField]int collisionCount = 0;
    float powerUpSpeed=0f;
    private PlayerMovement Pmove;
    private void Start()
    {
        Pmove = this.GetComponent<PlayerMovement>();
        powerUpSpeed = Pmove.moveSpeed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionCount++;
        Debug.Log(collisionCount);
    }
    // Update is called once per frame
    void Update()
    {
        if (collisionCount > 10)
        {
            Pmove.moveSpeed = powerUpSpeed * 10;

        }
                
    }
}
