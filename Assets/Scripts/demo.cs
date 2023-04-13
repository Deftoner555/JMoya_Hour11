using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{
    //this sets up a spawn manager

    public GameObject awesomeCube;
    void Start()
    {
        //public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace);
        //Instantiate(awesomeCube, new Vector3(1, 1, 1), awesomeCube.transform.rotation);
    }

    void Update()
    {
        Instantiate(awesomeCube, new Vector3(1, 1, 1), awesomeCube.transform.rotation);
    }
}
