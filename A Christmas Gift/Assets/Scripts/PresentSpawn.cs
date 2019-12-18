using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentSpawn : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    [SerializeField] float minY;
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
            instacia.transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

            Instantiate(instacia);
        }
    }
}
