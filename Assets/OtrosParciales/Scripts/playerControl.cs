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
    float scaleNormal,scaleInvertido;
    Animator animPlayer;
    void Start()
    {
        //Obtenemos el componente animator de nuestro player
        animPlayer = GetComponent<Animator>();
        //Obtenemos el componente rigidbody de nuestro objeto
        cuerpoPlayer = GetComponent<Rigidbody2D>();
        saltos = 2;
        //Estas lineas solo es para los que alteraron el scale
        scaleNormal = transform.localScale.x;
        scaleInvertido = transform.localScale.x * -1f;
    }

    void Update()
    {
        //Esto es lo del movimiento
        float posX = Input.GetAxis("Horizontal")*speed;
        cuerpoPlayer.velocity=new Vector2(posX,cuerpoPlayer.velocity.y);
        if(posX > 0)
        {
            animPlayer.SetBool("run", true);
            //Esto es si no escalaron a su personaje manualmente
            transform.localScale = new Vector3(1,1,1);
            //Eso usenlo si movieron la escala (estiraron) del personaje
            //transform.localScale = new Vector3(scaleNormal,transform.localScale.y,transform.localScale.z);
        }
        else if(posX < 0)
        {
            animPlayer.SetBool("run", true);
            //Esto es si no escalaron a su personaje manualmente
            transform.localScale = new Vector3(-1, 1, 1);
            //Eso usenlo si movieron la escala (estiraron) del personaje
            //transform.localScale = new Vector3(scaleInvertido,transform.localScale.y,transform.localScale.z);
        }
        else
        {
            //Aqui va la animacion de espera
            animPlayer.SetBool("run", false);
        }


        //Esto es lo de Salto
        if (Input.GetButtonDown("Jump")&&saltos>0)
        {
            //Animacion de Brinco
            animPlayer.SetTrigger("jump");
            animPlayer.SetBool("ground", false);
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
            animPlayer.SetBool("ground",true);
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
