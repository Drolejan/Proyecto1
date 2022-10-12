using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlataforma : MonoBehaviour
{
    float posX;

    // El start sucede solo una vez
    void Start()
    {
        Debug.Log("Hola Unity");
        posX = transform.position.x;//Asignamos la pos inicial de Unity
        Debug.Log(posX);
        transform.position = new Vector2(posX, transform.position.y);
    }

    // El update se ejecuta todos los frames
    void Update()
    {
        Debug.Log(posX);
        //Opcion 1 para reasignar el valor de una variable
        //posX = posX + 0.001f;
        //Opcion 2
        posX += 0.001f;
        //Actualizamos la posición cada frame
        transform.position = new Vector2(posX, transform.position.y);
        if (posX > 12)
        {
            posX = -12;
        }
    }
}
