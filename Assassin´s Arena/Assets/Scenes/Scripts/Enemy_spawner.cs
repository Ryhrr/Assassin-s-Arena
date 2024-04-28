using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Enemy_spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private bool Spawn = true;
    [SerializeField] float spawn_range = 100;
    public Transform transform;
    private Transform transform_Mage;
    int nr = 0;
    int Enemy_nr = 5;

    void Start()
    {
       StartCoroutine (Spawner());
        transform.GetComponent<Transform>();
        transform_Mage = FindObjectOfType<NewBehaviourScript>().transform;
    }


    // Update is called once per frame
    private IEnumerator Spawner()
    {
        while(Spawn)
        {



            WaitForSeconds wait = new WaitForSeconds(spawnRate);




            do
            {

                yield return wait;
                int rand = Random.Range(0, enemyPrefabs.Length);
                GameObject enemyToSpawn = enemyPrefabs[rand];

                Instantiate(enemyToSpawn, transform.position, Quaternion.identity);

                nr += 1;


            }while(true);


        }

    }

}
