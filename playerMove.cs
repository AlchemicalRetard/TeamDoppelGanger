using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMove : MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody rb;
    Vector3 movement;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        /*movement.z = Input.GetAxisRaw("Forward");*/
        
        /*animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);*/
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * walkSpeed * Time.fixedDeltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime);
    }

}
