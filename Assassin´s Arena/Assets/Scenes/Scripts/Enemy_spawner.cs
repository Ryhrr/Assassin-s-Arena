using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool spawn = true;
    [SerializeField] private float spawnRange = 100f;
    private Transform playerTransform;
    private int enemyCount = 0;
    private int maxEnemies = 600;

    void Start()
    {
        playerTransform = FindObjectOfType<NewBehaviourScript>().transform;
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(spawnRate);

            if (enemyCount < maxEnemies)
            {
                float randomY = Random.Range(playerTransform.position.y - spawnRange, playerTransform.position.y + spawnRange);
                float randomX = Mathf.Sqrt(Mathf.Pow(spawnRange, 2) - Mathf.Pow(randomY, 2));
                float randomAngle = Random.Range(0f, 360f);
                Vector3 spawnPosition = new Vector3(playerTransform.position.x + randomX * Mathf.Cos(randomAngle * Mathf.Deg2Rad), randomY, playerTransform.position.z + randomX * Mathf.Sin(randomAngle * Mathf.Deg2Rad));

                int rand = Random.Range(0, enemyPrefabs.Length);
                GameObject enemyToSpawn = enemyPrefabs[rand];

                Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);

                enemyCount += 1;
            }
            else
            {

                spawn = false;
            }
        }
    }
}