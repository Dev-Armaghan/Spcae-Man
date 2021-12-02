using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float moveLeft=10;
    private Vector3 startPosition;
    
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        startPosition.x = transform.position.x;
       
    }

    // Update is called once per frame
    void Update()
    {
        RepeatBackground();
    }

    void RepeatBackground()
    {
        background.transform.Translate(new Vector3( -1, 0, 0) * moveLeft * Time.deltaTime);
        if(background.transform.position.x < startPosition.x -  20)
        {
            background.transform.position = startPosition;
        }
    }
}
