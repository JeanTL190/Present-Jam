using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowReload : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] float maxY;
    [SerializeField] float minX;
    [SerializeField] float minY;
    [SerializeField] float timeSpawnMax = 15f;
    [SerializeField] float timeSpawnMin = 5f;
    [SerializeField] GameObject[] snowReload;

    private void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(timeSpawnMin,timeSpawnMax));
            GameObject instacia = snowReload[Random.Range(0, snowReload.Length - 1)];
            instacia.transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(instacia);
        }
    }
}
