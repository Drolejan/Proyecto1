using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuMove : MonoBehaviour
{
    Transform posPelota;
    public float cpuLevel;//Usar Numeros entre 0.5 y 0.9
    void Start()
    {
        posPelota = GameObject.Find("BALL").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, posPelota.position.y*cpuLevel);
    }
}
