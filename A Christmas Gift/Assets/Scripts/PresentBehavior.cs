using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentBehavior : MonoBehaviour
{
    [SerializeField] float timeLife = 10f;
    [SerializeField] int health = 50;
    Score score;
    void Start()
    {
        StartCoroutine("Sobreviveu");
        score = FindObjectOfType<Score>();
    }

    void Update()
    {

    }

    public void TookDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator Sobreviveu() {
        yield return new WaitForSeconds(timeLife);
        if (health > 0)
        {
            score.Pontua(health);
            Destroy(this.gameObject);
        }
    }
}
