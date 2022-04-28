using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    public float repeatRate = 1;

    private PlayerController PlayerControllerScript;



    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    void SpawnObstacle()
    {
        if (PlayerControllerScript.gameOver == false) {
             Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
