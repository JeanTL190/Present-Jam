using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentBehavior : MonoBehaviour
{
    [SerializeField] float timeLife = 10f;
    [SerializeField] int health = 50;
    void Start()
    {
        StartCoroutine("Sobreviveu");
    }

    void Update()
    {

    }

    private void TookDamage()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator Sobreviveu() {
        yield return new WaitForSeconds(timeLife);
        if (health > 0)
        {
            // Pontua
            Destroy(this.gameObject);
        }
    }
}
