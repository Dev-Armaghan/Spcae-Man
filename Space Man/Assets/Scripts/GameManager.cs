using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float moveLeftSpeed=10;
    private Vector3 startPosition;
    
    public GameObject background;
    public GameObject spawnManagerReference;

    SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        startPosition.x = transform.position.x;
        spawnManager = spawnManagerReference.GetComponent<SpawnManager>();
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        RepeatBackground();
    }

    void RepeatBackground()
    {
        //background.transform.Translate(new Vector3( -1, 0, 0) * moveLeft * Time.deltaTime);
        MoveLeft(background);
        if(background.transform.position.x < startPosition.x -  20)
        {
            background.transform.position = startPosition;
        }
    }

    void MoveLeft(GameObject toMoveLeft)
    {
        toMoveLeft.transform.Translate(new Vector3(-1, 0, 0) * moveLeftSpeed * Time.deltaTime);
    }

    void SpawnEnemy()
    {
        StartCoroutine(spawnManager.SpawnAfterInterval());
        MoveLeft(spawnManager.spawnedEnemy);
    }
}
