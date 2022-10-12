using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerControl : MonoBehaviour
{
    Rigidbody2D cuerpoPlayer;
    public float speed;
    public float fuerzaBrinco;
    int saltos;
    public TextMeshProUGUI textoScore;
    public Transform respawnPoint;//Coordenadas de mi punto de respawn
    void Start()
    {
        //Obtenemos el componente rigidbody de nuestro objeto
        cuerpoPlayer = GetComponent<Rigidbody2D>();
        saltos = 2;
    }

    void Update()
    {
        float posX = Input.GetAxis("Horizontal")*speed;
        cuerpoPlayer.velocity=new Vector2(posX,cuerpoPlayer.velocity.y);
        if (Input.GetButtonDown("Jump")&&saltos>0)
        {
            cuerpoPlayer.AddForce(new Vector2(0, fuerzaBrinco));
            saltos -= 1;
            //tambien se puede poner asi: saltos--
        }       
    }

    //Este bloque se ejecuta cuando colisionamos con "algo"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            saltos = 2;//Recargo mis saltos al tocar el suelo
        }
        //Al chocar con el enemigo, hago respawn al punto indicado
        if (collision.gameObject.CompareTag("enemy"))
        {//Reaparecemos en el punto de respawn definido en Unity
            transform.position = respawnPoint.position;
        }
    }

    //Estas variables pueden ir en donde sea con que no esten
    // dentro de un bloque de codigo, solo estan dentro de tu
    // script
    public int puntos;//Esto es una variable global tambien
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("point"))
        {
            puntos += 1;
            //Al combinar dos textos se le llama concatenación
            textoScore.text = "Puntos: " + puntos.ToString();
            Destroy(collision.gameObject);//Destruimos el punto
        } 
    }

}
