using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoelMovement : MonoBehaviour
{
    [SerializeField] private int vida = 100;
    [SerializeField] private int damage;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    private void Die()
    {
        if (vida < 0)
        {
            // Chama animacao de morte e cena de game over
        }
    }
    private void Atack()
    {
        // animacao de atk
    }
    private void TookDamege()
    {
        //animacao de dano
    }
}
