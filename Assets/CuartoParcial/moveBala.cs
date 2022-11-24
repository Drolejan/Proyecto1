using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBala : MonoBehaviour
{
    float balaVel;
    float posXbala;
    void Start()
    {
        Destroy(gameObject, 3f);
        balaVel = Random.Range(0.01f, 0.05f);//Velocidad inicial de la bala
        posXbala = transform.position.x;//Pos inicial de la bala
    }

    void Update()
    {
        transform.position = new Vector2(posXbala,transform.position.y);
        posXbala += balaVel;//Le sumamos la velocidad a la pos
    }
}
