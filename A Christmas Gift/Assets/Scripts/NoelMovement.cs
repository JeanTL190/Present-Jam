using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoelMovement : MonoBehaviour
{
    [SerializeField] private int vida = 100;
    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Animator animacao;
    private float moveSpeed;
    Vector2 movement;
    Vector2 posicaoAtual;
    private void Start()
    {
        moveSpeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.y != 0)
        {
            if (movement.y > 0)
            {
                posicaoAtual = new Vector2(0, 1);
            }
            else
            {
                posicaoAtual = new Vector2(0, -1);
            }
        }

        else if(movement.x!=0){
            if (movement.x > 0)
            {
                posicaoAtual = new Vector2(1,0);
            }
            else
            {
                posicaoAtual = new Vector2(-1, 0);
            }
        }
        animacao.SetFloat("Horizontal", movement.x);
        animacao.SetFloat("Vertical", movement.y);
        animacao.SetFloat("Speed", movement.sqrMagnitude);
        animacao.SetFloat("PosiHorizontal", posicaoAtual.x);
        animacao.SetFloat("PosiVertical", posicaoAtual.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if(Input.GetButtonDown("Atack c"))
        {
            Atack();
        }
    }

    private void zeroSpeed()
    {
        moveSpeed = 0;
    }
    private void resetSpeed()
    {
        moveSpeed = speed;
    }
    private void Atack()
    {
        animacao.SetTrigger("Atack");
    }
    public void TookDamage(int damage)
    {
        //chama animacao de apanhar
        vida -= damage;
        if (vida < 0)
        {
            // Chama animacao de morte e cena de game over
        }
    }
}
