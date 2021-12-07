using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefab;

    private GameObject spawnedEnemy;

    private float enemySpawnTime = 5;  // spawn time for normal enemy
    private float enemyYRange = 2.35f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public IEnumerator SpawnAfterInterval()
    {
        yield return new WaitForSeconds(enemySpawnTime);
        SpawnNormalEnemy();
        SpawnAfterInterval();
        Debug.Log("Coroutine is working");
    }

    public void SpawnNormalEnemy()
    {
        int randomIndex = Random.Range(0, enemyPrefab.Length); // for choosing the random enemy(planet)

        Vector2 randomPosition = new Vector2(11, Random.Range(-enemyYRange, enemyYRange + 1));

        spawnedEnemy = Instantiate(enemyPrefab[randomIndex], randomPosition, enemyPrefab[randomIndex].transform.rotation);

        spawnedEnemy.transform.Translate(new Vector2(-1,0) * 20 * Time.deltaTime);
        //GameManager.GM.MoveLeft(spawnedEnemy);
    }
}
