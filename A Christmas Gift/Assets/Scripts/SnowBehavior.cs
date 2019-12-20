using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        NoelMovement player = other.GetComponent<NoelMovement>();
        if (player != null)
        {
            player.Reload((int)Random.Range(5, 15));
            Debug.Log("Cheguei");
        }

    }
}
