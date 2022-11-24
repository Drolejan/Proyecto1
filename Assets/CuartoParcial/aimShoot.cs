using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimShoot : MonoBehaviour
{
    Transform posMira;
    public GameObject bala;
    AudioSource sfxBala;
    void Start()
    {
        posMira = GameObject.Find("Mira").GetComponent<Transform>();
        sfxBala=GetComponent<AudioSource>();//Obtengo mi componente de audio
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, posMira.transform.position,Quaternion.identity);
            sfxBala.Play();//Reproducimos el audio
            //Hacer temporizador
        }
    }
}
