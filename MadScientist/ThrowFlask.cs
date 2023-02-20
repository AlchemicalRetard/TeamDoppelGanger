using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFlask : MonoBehaviour
{
    public Transform flaskSpawn;
    public GameObject flaskPrefab;

    public float velocity;
    public float interval = 4f;

    private float timeSinceLastShot;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if(timeSinceLastShot >= interval)
        {
            timeSinceLastShot = 0;
            var flask = Instantiate(flaskPrefab , flaskSpawn.position , flaskSpawn.rotation);
            Rigidbody rb = flask.GetComponent<Rigidbody>();
            rb.AddForce(flask.transform.forward * velocity , ForceMode.VelocityChange);
        }
    }
}
