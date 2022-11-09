using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   [SerializeField]
   private GameObject EnemyBasePrefab; 

   [SerializeField]
   private float EnemyBaseInterval = 3.5f;
        
// Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyBaseInterval, EnemyBasePrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-0f, 0), Random.Range(-0f, 0),0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
