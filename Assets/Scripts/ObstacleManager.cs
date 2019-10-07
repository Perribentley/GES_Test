using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour

{
    public GameObject[] ObstaclePrefabs;
    private float SpawnRangeX = 10;
    private float SpawnRangeZ = 200;

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 100; i++)
        {
            int ObstacleIndex = Random.Range(0, ObstaclePrefabs.Length);
            Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, Random.Range(-SpawnRangeZ, SpawnRangeZ));
            Instantiate(ObstaclePrefabs[ObstacleIndex], SpawnPos, ObstaclePrefabs[ObstacleIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
