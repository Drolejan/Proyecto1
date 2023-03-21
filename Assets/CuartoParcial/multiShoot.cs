using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiShoot : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 mousePos;
    float movX, movY,angulo;
    
    public GameObject balaNueva;
    public float bulletForce;
    public float velPlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Para el movimiento
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        //Velocidad del player
        rb.velocity = new Vector2(movX, movY)*velPlayer;

        mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Para que nuestro objeto que se mueve con el mouse dispare
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject labala = Instantiate(balaNueva,transform.position, Quaternion.identity);
            Rigidbody2D balarb = labala.GetComponent<Rigidbody2D>();
            balarb.rotation = angulo;
            balarb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
            Destroy(labala, 3f);
        }
    }

    private void FixedUpdate()
    {
        //Paso 1 Calcular la direccion a donde apunta el mouse
        Vector2 lookDir = mousePos - rb.position;
        //Paso 2 Calcular el angulo de la direccion y convertirlo a grados
        angulo = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        //Paso 3 rotar el objeto al angulo calculado
        rb.rotation = angulo;
    }

}
