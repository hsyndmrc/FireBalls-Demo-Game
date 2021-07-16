using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab1;
    [SerializeField] private GameObject cubePrefab2;



    void Start()
    {
        SimplePool.Preload(cubePrefab1, 50);
        SimplePool.Preload(cubePrefab2, 50);
        SpawnLevelCubes();
    }

    public void SpawnLevelCubes()
    {
        int rnd = Random.Range(25, 35);
        Vector3 pos = new Vector3(0, 0.5f, -9.5f);
        for (int i = 0; i < rnd; i++)
        {
            SimplePool.Spawn(cubePrefab1, pos, cubePrefab1.transform.rotation);
            pos.y = pos.y + 0.55f;
            SimplePool.Spawn(cubePrefab2, pos, cubePrefab2.transform.rotation);
            pos.y = pos.y + 0.55f;
        }
    }



}
