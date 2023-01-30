using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn: MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private GameObject Small;
    [SerializeField]private GameObject Med;
    //[SerializeField] private GameObject Large;
    //time
    [SerializeField] private float SmallKaTime=3.5f;
    [SerializeField] private float MedKaTime=5.5f;
    //[SerializeField] private float LargeKaTime=10f;
    [SerializeField] private Transform playerPosition;
    void Start()
    {
        StartCoroutine(spawnEnemy(SmallKaTime, Small));
        StartCoroutine(spawnEnemy(MedKaTime, Med));
        //StartCoroutine(spawnEnemy(LargeKaTime, Large));
    }

    // Update is called once per frame
   public IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy =Instantiate(enemy,new Vector3(Random.Range(-5f,0),.4f, Random.Range(-6f, 6)),Quaternion.identity);
        newEnemy.GetComponent<followEnemy>().target = playerPosition;
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
