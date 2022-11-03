using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBall : MonoBehaviour
{
    Vector3 centro;
    Rigidbody2D rbPelota;
    void Start()
    {
        centro = Vector3.zero;//Este es el Vector3 (0,0,0)
        transform.position = centro;
        rbPelota = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Iniciamos el Juego
            rbPelota.velocity = new Vector2(1, 1);
        }
    }
}
