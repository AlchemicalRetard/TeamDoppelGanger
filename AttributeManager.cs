using UnityEngine;
using UnityEngine.SceneManagement;
public class AttributeManager : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player takes " + damage + " damage. Health: " + health);
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyProjectile"))
        {
            TakeDamage(20);
            Destroy(other.gameObject);
            Debug.Log(health);
        }
    }

   
}
