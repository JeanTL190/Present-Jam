using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float Speed = 1f;
    NoelMovement noel;
    private Vector3 posiInicial;
    // Start is called before the first frame update
    void Start()
    {
        noel = FindObjectOfType<NoelMovement>();
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(noel.getPosicaoAtual());
        rb.velocity = noel.getPosicaoAtual() * Speed;
        posiInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude - posiInicial.magnitude >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
