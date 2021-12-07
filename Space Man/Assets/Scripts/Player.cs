using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public float upForce;

    public Animator playerAnimation;
    public AudioClip landSound;


    private AudioSource playerAudio;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(Vector2.up * upForce);
            playerAnimation.SetBool("Flying", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerAnimation.SetBool("Flying", false);
            playerAudio.PlayOneShot(landSound, 1.0f);
        }
    }

}
