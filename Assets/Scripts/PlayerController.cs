using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f; // La fuerza del salto
    private bool isGrounded;
    private Rigidbody2D rb; // Usaremos Rigidbody2D en lugar de Rigidbody para 2D

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Determinar si el jugador está en el suelo
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f);

        // Salto
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            // Aplicar una fuerza vertical para saltar
            rb.velocity = new Vector2(rb.velocity.y, jumpForce);
        }
    }
}
