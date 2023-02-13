using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed; 

    private Vector3 movement; 
    private Rigidbody rb;
   // private Animator anim;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
        //anim = GetComponent<Animator>();
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical"); 
       // anim.SetFloat("Horizontal", horizontal);
       // anim.SetFloat("Vertical", vertical);

       

        Move(horizontal, vertical); 
    }

    private void Move(float horizontal, float vertical)
    {
        movement = new Vector3(horizontal, 0f, vertical); 
        movement = Quaternion.Euler(new Vector3(0, 90, 0)) * movement; // Rotate the movement vector by 90 degrees , which provides a sideways movement
        movement = movement.normalized * moveSpeed * Time.deltaTime; 

        rb.MovePosition(transform.position + movement); 
    }
}

