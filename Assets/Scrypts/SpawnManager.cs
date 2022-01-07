using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstacles;
    Vector3 spawnPos = new Vector3(37, 0, 0);
    float startDelay = 2;
    float repeatRate = 2;
    PlayerController playerControllerScrypt;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScrypt = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!playerControllerScrypt.gameOver)
        {
            repeatRate = Random.Range(1.5f, 3.5f);
            int element = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[element], spawnPos, obstacles[element].transform.rotation);
        }
    }
}
