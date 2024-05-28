using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 5f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool spawn = true;
    [SerializeField] private float spawnRange = 100f;
   
    public Deathcounter Deathcounter;

    private Transform playerTransform;
    private int enemyCount = 0;
    private int maxEnemies = 1;
    public static int Welle = 1;
    public static int Welletxt;
    float allEnemys = 0;
    

    void Start()
    {
        playerTransform = FindObjectOfType<NewBehaviourScript>().transform;
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (spawn)
        {

            Enemy_Health.Kills_this_Round = 0;

            do
            {

                yield return new WaitForSeconds(spawnRate);

                float randomY = Random.Range(playerTransform.position.y - spawnRange, playerTransform.position.y + spawnRange);
                float randomX = Mathf.Sqrt(Mathf.Pow(spawnRange, 2) - Mathf.Pow(randomY, 2));
                float randomAngle = Random.Range(0f, 360f);
                Vector3 spawnPosition = new Vector3(playerTransform.position.x + randomX * Mathf.Cos(randomAngle * Mathf.Deg2Rad), randomY, playerTransform.position.z + randomX * Mathf.Sin(randomAngle * Mathf.Deg2Rad));

                int rand = Random.Range(0, enemyPrefabs.Length);
                GameObject enemyToSpawn = enemyPrefabs[rand];

                Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);

                enemyCount++;

            }while (enemyCount >= maxEnemies);


            enemyCount = 0;

            if (Welle == 21)
            {
                spawn = false;
            }


            yield return new WaitForSeconds(spawnRate);

            if (Welle == 1)
            {
                maxEnemies = 5;
                spawnRate = 2f;
                Welle = 2;
            }
            else if (Welle == 2)
            {
                maxEnemies = 10;
                spawnRate = 2f;
                Welle = 3;
            }
            else if (Welle == 3)
            {
                maxEnemies = 20;
                spawnRate = 2f;
                Welle = 4;
            }
            else if (Welle == 4)
            {
                maxEnemies = 25;
                spawnRate = 2f;
                Welle = 5;
            }
            else if (Welle == 5)
            {
                maxEnemies = 30;
                spawnRate = 2f;
                Welle = 6;
            }
            else if (Welle == 6)
            {
                maxEnemies = 35;
                spawnRate = 2f;
                Welle = 7;
            }
            else if (Welle == 7)
            {
                maxEnemies = 40;
                spawnRate = 1f;
                Welle = 8;
            }
            else if (Welle == 8)
            {
                maxEnemies = 50;
                spawnRate = 1f;
                Welle = 9;
            }
            else if (Welle == 9)
            {
                maxEnemies = 50;
                spawnRate = 1f;
                Welle = 10;
            }
            else if (Welle == 10)
            {
                maxEnemies = 50;
                spawnRate = 1f;
                Welle = 11;
            }
            else if (Welle == 11)
            {
                maxEnemies = 60;
                spawnRate = 1f;
                Welle = 12;
            }
            else if (Welle == 12)
            {
                maxEnemies = 60;
                spawnRate = 1f;
                Welle = 13;
            }
            else if (Welle == 13)
            {
                maxEnemies = 70;
                spawnRate = 1f;
                Welle = 14;
            }
            else if (Welle == 14)
            {
                maxEnemies = 75;
                spawnRate = 1f;
                Welle = 15;
            }
            else if (Welle == 15)
            {
                maxEnemies = 75;
                spawnRate = 1f;
                Welle = 16;
            }
            else if (Welle == 16)
            {
                maxEnemies = 80;
                spawnRate = 1f;
                Welle = 17;
            }
            else if (Welle == 17)
            {
                maxEnemies = 70;
                spawnRate = 1f;
                Welle = 18;
            }
            else if (Welle == 18)
            {
                maxEnemies = 80;
                spawnRate = 0.5f;
                Welle = 19;
            }
            else if (Welle == 19)
            {
                maxEnemies = 90;
                spawnRate = 0.5f;
                Welle = 20;
            }
            else if (Welle == 20)
            {
                maxEnemies = 150;
                spawnRate = 0.5f;
                Welle = 21;
            }

        }
    }
}