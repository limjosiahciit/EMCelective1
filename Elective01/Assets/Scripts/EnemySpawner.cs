using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRadius = 4, time = 1.5f;

    public GameObject enemy,PlayerPos, playerGO,temp;

    void Start()
    {
        StartCoroutine(Getter());
        StartCoroutine(SpawnEnemy());
        temp = PlayerPos;
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(time);
        
        if (PlayerPos == null){PlayerPos = temp;}
        Vector2 spawnPos = PlayerPos.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemy, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator Getter()
    {
        yield return new WaitForSeconds(1f);
        PlayerPos = playerGO.GetComponent<GameManager>().playerGO;
    }
}
