using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM; // creating game manager instance

    public bool gameOver;
    public float moveLeftSpeed=5;
    private Vector3 startPosition;
    private Button button;


    public GameObject background;
    public GameObject spawnManagerReference;
    public GameObject gameOverUI;


    private void Awake()
    {
        GM = this;
    }
    
    void Start()
    {
        
        startPosition.x = transform.position.x; // to get the reference of the background to make it repeat
        button = GetComponent<Button>();
    }


    void Update()
    {
        if(gameOver == false) //untill the game is over background will repeat.
        {
        RepeatBackground();
        }
        else
        {
            gameOverUI.gameObject.SetActive(true);
        }
        
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

    public void MoveLeft(GameObject toMoveLeft)  // to make the objects go from left too right.
    {
        toMoveLeft.transform.Translate(new Vector3(-1, 0, 0) * moveLeftSpeed * Time.deltaTime);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void SetDifficulty()
    {

    }

}
