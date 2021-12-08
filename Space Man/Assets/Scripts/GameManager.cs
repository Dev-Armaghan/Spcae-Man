using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM; // creating game manager instance

    public float moveLeftSpeed=5;
    private Vector3 startPosition;
    
    public GameObject background;
    public GameObject spawnManagerReference;

    SpawnManager spawnManager;

    private void Awake()
    {
        GM = this;
    }
    
    void Start()
    {
        startPosition.x = transform.position.x;
        spawnManager = spawnManagerReference.GetComponent<SpawnManager>();
        
    }


    void Update()
    {
        RepeatBackground();
    }

    #region repeating backgrond
    void RepeatBackground()
    {
        //background.transform.Translate(new Vector3( -1, 0, 0) * moveLeft * Time.deltaTime);
        MoveLeft(background);
        if(background.transform.position.x < startPosition.x -  12)
        {
            background.transform.position = startPosition;
        }
    }
    #endregion

    public void MoveLeft(GameObject toMoveLeft)
    {
        toMoveLeft.transform.Translate(new Vector3(-1, 0, 0) * moveLeftSpeed * Time.deltaTime);
    }


    
}
