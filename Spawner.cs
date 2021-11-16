using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform[] SpawnPoint;
    //public Status Status;

    private int Rand;
    private int RandPosition;

    public float StartTimeBetweenSpawn;
    private float TimeBetweenSpawns;

    private void Start()
    {
        TimeBetweenSpawns = StartTimeBetweenSpawn;
    }
    private void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            if (TimeBetweenSpawns <= 0)
            {
                if(Status.playerScore <= 30)
                {
                    Rand = Random.Range(0, 1);
                } else if(Status.playerScore > 30 && Status.playerScore <= 100)
                {
                    Rand = Random.Range(0, 2);
                    StartTimeBetweenSpawn = 1f;
                } else if(Status.playerScore > 100 && Status.playerScore <= 200)
                {
                    Rand = Random.Range(0, 3);
                    StartTimeBetweenSpawn = .85f;
                } else if(Status.playerScore > 200 && Status.playerScore <= 300)
                {
                    Rand = Random.Range(2, 3);
                    StartTimeBetweenSpawn = .6f;
                } else if(Status.playerScore > 300 && Status.playerScore <= 450)
                {
                    Rand = Random.Range(1, 3);
                    StartTimeBetweenSpawn = .8f;
                } else
                {
                    Rand = Random.Range(0, 4);
                }
                RandPosition = Random.Range(0, SpawnPoint.Length);
                Instantiate(Enemies[Rand], SpawnPoint[RandPosition].transform.position, Quaternion.identity);
                TimeBetweenSpawns = StartTimeBetweenSpawn;
            }
            else
            {
                TimeBetweenSpawns -= Time.deltaTime;
            }
        }
    }
}