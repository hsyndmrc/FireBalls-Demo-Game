using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab1;
    [SerializeField] private GameObject cubePrefab2;

    

    void Start()
    {
        SimplePool.Preload(cubePrefab1,50);
        SimplePool.Preload(cubePrefab2,50);
    }


    public void SpawnLevelCubes()
    {

    }



}
