using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

public float enemyHealth;
public float enemyDamage;
public float damageTaken;

public PlayerController player;

public void Attack(){

    ///TODO: Spawnar animação de ataque e tirar vida do player

}

private void OnTriggerEnter(Collider other) {
    if(other.tag == "Player"){

        Attack();

    }else if( other.tag == "PlayerAttack"){

        enemyHealth -= damageTaken;

    }
}

public void Die(){

    if(enemyHealth <= 0)
    {
        Destroy(this.gameObject);
    }

}

}
