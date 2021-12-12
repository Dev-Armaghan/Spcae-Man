using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float xDestroyLocation = -15;


 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBounds();
    }

    void DestroyOutOfBounds()
    {
        if(transform.position.x < xDestroyLocation)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameManager.GM.gameOver = true;
            Debug.Log("Game Over");
        }
    }
    
    
}
