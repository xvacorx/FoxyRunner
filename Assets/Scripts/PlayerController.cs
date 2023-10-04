using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 17.5f;
    private bool isGrounded;
    private Rigidbody2D rb;

    public ScoreScript score;
    public GameOverScreen Death;

    public SpriteRenderer deathAnimation;
    public SpriteRenderer runningAnimation;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        deathAnimation.enabled = false;
        runningAnimation.enabled = true;
    }


    private void Update()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            deathAnimation.enabled = true;
            runningAnimation.enabled = false;
            Death.ActiveScreen();
            score.DisableScreen();
        }
        isGrounded = true;
    }
}
