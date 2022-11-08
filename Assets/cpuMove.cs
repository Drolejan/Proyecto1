using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuMove : MonoBehaviour
{
    Transform posPelota;
    void Start()
    {
        posPelota = GameObject.Find("BALL").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, posPelota.position.y);
    }
}
