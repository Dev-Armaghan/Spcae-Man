using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefab;

    private GameObject spawnedEnemy;

    private float spawnRate = 3;  // spawn time for normal enemy
    private float  enemySpawnTime= 3;  // spawn time for normal enemy
    private float enemyYRange = 2.3f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNormalEnemy", enemySpawnTime, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.GM.gameOver == true)
        {
            CancelInvoke();
        }
    }


    /*public IEnumerator SpawnAfterInterval()
    {
        yield return new WaitForSeconds(enemySpawnTime);
        SpawnNormalEnemy();
        SpawnAfterInterval();
    }*/

    #region Spawning nomral enemy

    public void SpawnNormalEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length); // for choosing the random enemy(planet)

        Vector2 randomPosition = new Vector2(11, Random.Range(-enemyYRange, enemyYRange + 1));

        Instantiate(enemyPrefab[randomIndex], randomPosition, enemyPrefab[randomIndex].transform.rotation);

   }

    #endregion
}
