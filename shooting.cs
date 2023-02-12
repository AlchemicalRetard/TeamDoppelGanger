using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform playerPos;
    public GameObject projectileKaPrefab;
    [SerializeField]public float shootForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Vector3 shootDirection = GetShootDirection();
        Debug.Log("shootDirection: " + shootDirection);
        GameObject projectile = Instantiate(projectileKaPrefab, playerPos.position, Quaternion.identity);// here projectile is the name and GameObject is the type
        //Rigidbody rb=
        projectile.GetComponent<Rigidbody>().AddForce(playerPos.forward * shootForce, ForceMode.Impulse);
    }
    Vector3 GetShootDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 shootDirection = (mousePos - transform.position).normalized;
        //shootDirection.z = 0;

        return shootDirection;

    }
}
