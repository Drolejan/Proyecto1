using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongControl : MonoBehaviour
{
    public GameObject pelota;//Declaramos nuestro prefab de pelota
    //Vector3 control;

    void Start()
    {
        
    }

    void Update()
    {
        //control = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector3(transform.position.x,Mathf.Clamp(control.y,-4.5f,4.5f),0);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(pelota,transform.position,Quaternion.identity);//Crear una pelota en mi posición
        }
    }
}
