using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    private float timeBtwSpawn;
    public float StartTimeSpawn;
    public float decreaseTime;
    public float minTime = 1f;

    private void Update()
    {
        if(timeBtwSpawn <=0)
        {   
            int rand =  Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = StartTimeSpawn;
            if (StartTimeSpawn > minTime)
            {
                StartTimeSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
