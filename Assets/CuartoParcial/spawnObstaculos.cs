using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        while (true)
        {
            Debug.Log("HOLA");
            yield return new WaitForSeconds(3f);
            Instantiate(obstaculo, transform.position, Quaternion.identity);
        }
    }

}
