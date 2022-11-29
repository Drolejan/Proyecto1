using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//Libreria de Texto

public class controlTimer : MonoBehaviour
{
    public float duracion;//Lo que dura el timer
    public float tiempoActual;//El tiempo corriendo
    public TextMeshProUGUI textoTimer;
    void Start()
    {
        tiempoActual = duracion;
    }

    void Update()
    {
        if (tiempoActual > 0)//Restamos solo cuando seamos más que 0
        {
            tiempoActual -= Time.deltaTime;//Le Restamos el tiempo real
        }

        //Atualizamos el texto con el tiempo actual
        textoTimer.text = Mathf.RoundToInt(tiempoActual).ToString();
        
        if (Input.GetKeyDown(KeyCode.R))//Resetear el timer
        {
            tiempoActual = duracion;
        }
    }
}
