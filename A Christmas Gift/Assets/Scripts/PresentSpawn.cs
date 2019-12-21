using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentSpawn : MonoBehaviour
{
    public GameObject position;
    [SerializeField] float timeSpawn=5f;
    [SerializeField] GameObject[] presentes;

    private void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        while (true) {
            yield return new WaitForSeconds(timeSpawn);
            GameObject instacia = presentes[Random.Range(0, presentes.Length - 1)];
            instacia.transform.position = new Vector2(position.transform.position.x, position.transform.position.y);

            Instantiate(instacia);
        }
    }
}
