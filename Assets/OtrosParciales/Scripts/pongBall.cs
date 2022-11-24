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

    public GameObject panelVictoriaP1,panelVictoriaP2;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Iniciamos el Juego
            rbPelota.velocity = new Vector2(1, 1)*speed;
        }

        if (scoreP1 >= 5)//Si gana el player 1
        {
            Time.timeScale = 0;
            panelVictoriaP1.SetActive(true);
        }
        if (scoreP2 >= 5)//Si gana el player 2
        {
            Time.timeScale = 0;
            panelVictoriaP2.SetActive(true);
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

    public void reiniciar()//Esta función se la vamos a poner al boton de RESTART
    {
        scoreP1 = 0;
        scoreP2 = 0;
        Time.timeScale = 1;
        panelVictoriaP1.SetActive(false);
        panelVictoriaP2.SetActive(false);
        textoP1.text = scoreP1.ToString();
        textoP2.text = scoreP2.ToString();
    }
}
