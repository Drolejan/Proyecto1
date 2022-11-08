using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pongBall : MonoBehaviour
{
    Vector3 centro;
    Rigidbody2D rbPelota;
    public float speed;//Velocidad de la pelota
    public int scoreP1, scoreP2;//Variables de Score
    public TextMeshProUGUI textoP1, textoP2;//Textos de Score
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
            rbPelota.velocity = new Vector2(1, 1)*speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PorteriaPlayer2"))
        {
            transform.position = centro;
            rbPelota.velocity = Vector2.zero;
            //Aqui sumariamos puntos al Player 1
            scoreP1++;
            textoP1.text = scoreP1.ToString();
        }
        else if (collision.gameObject.CompareTag("PorteriaPlayer1"))
        {
            transform.position = centro;
            rbPelota.velocity = Vector2.zero;
            //Aqui sumariamos puntos al Player 2
            scoreP2++;
            textoP2.text = scoreP2.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Aqui agregaremos despues un rebote mas avanzado
    }
}
