﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        //Enemy enemy = other.GetComponent<Enemy>();
        NoelMovement player = other.GetComponent<NoelMovement>();
        if(enemy!=null)
        {
            //enemy.TookDamage(damage);
        }
        if(player!=null)
        {
            player.TookDamage(damage);
        }

    }
}
