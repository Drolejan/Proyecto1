using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    Collider2D limites;
    void Start()
    {
        StartCoroutine(spawner());
        limites = GetComponent<Collider2D>();
    }

    IEnumerator spawner()
    {
        while (true)
        {
            Debug.Log("HOLA");
            yield return new WaitForSeconds(3f);
            //Forma 1 con datos FIJOS definidos por el programador
            Vector2 posAleatoria = new Vector2(transform.position.x, Random.Range(-4.5f, 4.5f));
            //Forma 2 utilizando los limites de un objeto como referencia
            Vector2 posAleatoria2 = new Vector2(transform.position.x, Random.Range(limites.bounds.min.y,limites.bounds.max.y));
            Instantiate(obstaculo, posAleatoria2, Quaternion.identity);
        }
    }

}
