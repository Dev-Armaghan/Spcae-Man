using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefab;
    private float enemySpawnTime=2;  // spawn time for normal enemy
    private float enemyYRange=2.35f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAfterInterval());
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    IEnumerator SpawnAfterInterval()
    {
        yield return new WaitForSeconds(enemySpawnTime);
        SpawnNormalEnemy();
    }
    void SpawnNormalEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length); // for choosing the random enemy(planet)
        
        Vector2 randomPosition = new Vector2(11,Random.Range(-enemyYRange,enemyYRange));
        
        Instantiate(enemyPrefab[randomIndex],randomPosition,enemyPrefab[randomIndex].transform.rotation);
    }
}
