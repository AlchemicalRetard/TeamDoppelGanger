using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    [HideInInspector] public Transform target = null; // dusri script se leti hai

    public float minDistance;
    private void Update()
    {
        /*if (Vector3.Distance(transform.position, target.position) > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }*/
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
