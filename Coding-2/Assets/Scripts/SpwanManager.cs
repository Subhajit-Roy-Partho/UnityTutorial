using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnXrange = 10;
    public float startDelay=2f;
    public float spawnInterval=0.2f;

    void SpawnAnimals(){
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXrange, spawnXrange),0,20);
        Instantiate(animals[animalIndex],spawnPos,animals[animalIndex].transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.S)){
            SpawnAnimals();
        }
    }
}
