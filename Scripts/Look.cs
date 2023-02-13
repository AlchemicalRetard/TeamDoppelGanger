using UnityEngine;

public class Look : MonoBehaviour
{
    
    [SerializeField] LayerMask aimLayerMask; //add ground layer

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray , out RaycastHit hitInfo , Mathf.Infinity , aimLayerMask))
        {
            var destination =  hitInfo.point;
            destination.y = transform.position.y;

            Vector3 direction =  destination - transform.position;
            direction.Normalize();

            transform.rotation = Quaternion.LookRotation(direction ,  Vector3.up);
        }
    }
}

