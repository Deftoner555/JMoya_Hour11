using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 spawnValues;
    public float spawnInterval;

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Vector3 spawnposition = new Vector3(i * spawnInterval, 1f, Random.Range(-spawnValues.z, spawnValues.z));
            GameObject GO = Instantiate<GameObject>(prefab, spawnposition, Quaternion.identity);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
