using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiShoot : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 mousePos;
    float movX, movY;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Para el movimiento
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(movX, movY);

        mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        //Paso 1 Calcular la direccion a donde apunta el mouse
        Vector2 lookDir = mousePos - rb.position;
        //Paso 2 Calcular el angulo de la direccion y convertirlo a grados
        float angulo = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        //Paso 3 rotar el objeto al angulo calculado
        rb.rotation = angulo;
    }

}
