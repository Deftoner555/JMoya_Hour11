using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 spawnValues;

    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1f, Random.Range(-spawnValues.z, spawnValues.z));
            GameObject GO = Instantiate<GameObject>(prefab, spawnposition, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
