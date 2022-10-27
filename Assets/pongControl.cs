using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongControl : MonoBehaviour
{
    public GameObject pelota;//Declaramos nuestro prefab de pelota
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(pelota,transform.position,Quaternion.identity);//Crear una pelota en mi posición
        }
    }
}
