using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBehavior : MonoBehaviour
{
    [SerializeField] float timeLife = 10f;
    private void Start()
    {
        StartCoroutine("Despawn");
    }
    private void OnTriggerEnter(Collider other)
    {
        NoelMovement player = other.GetComponent<NoelMovement>();
        if (player != null)
        {
            player.Reload((int)Random.Range(5, 15));
            Debug.Log("Cheguei");
        }

    }
    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(timeLife);
            Destroy(this.gameObject);
    }
}
