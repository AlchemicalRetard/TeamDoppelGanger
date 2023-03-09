/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    [HideInInspector] public Transform target = null; // dusri script se leti hai
    private Animator anim;

    public float minDistance;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {

        if (Vector3.Distance(transform.position, target.position) > minDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.LookAt(target);

        }
        if (Vector3.Distance(transform.position, target.position) > 0.1f)
        {

            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}*/
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followEnemy : MonoBehaviour
{
    [SerializeField] float minDistance = 2f;
    [SerializeField] float stoppingDistance = 1f;
    [SerializeField] float updateRate = 0.5f;
    [SerializeField] bool canMove = true;

    private NavMeshAgent agent;
    private Animator anim;
    public Transform target;

    private float timer;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform; // You can change "Player" to the tag of your target object
        timer = 0f;
    }

    private void Update()
    {
        if (!canMove)
            return;

        timer += Time.deltaTime;

        if (timer >= updateRate)
        {
            agent.SetDestination(target.position);
            timer = 0f;
        }

        if (agent.remainingDistance > stoppingDistance)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
