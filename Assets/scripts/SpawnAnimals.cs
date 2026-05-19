using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float x = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0,3);
            Vector3 animalPoz = new Vector3(Random.Range(-x, x), 0, x);

            Instantiate(animalPrefabs[animalIndex], animalPoz, animalPrefabs[animalIndex].transform.rotation);
    }
}
