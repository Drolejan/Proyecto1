using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;

    void Start()
    {
        Time.timeScale = 0;//Aqui esta congelado el tiempo
        //Esto detiene las fisicas y el tiempo en general
        //Pero no detiene los inputs ni los cambios en el update
    }

    void Update()
    {
        
    }

    public void comenzar()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1;//Aqui vuelve a correr el tiempo
    }

    public void cargarNivel()
    {
        //Colocar el nombre de TU escena, la mia se llama Programa
        SceneManager.LoadScene("Programa");
        Time.timeScale = 1;
    }
}
