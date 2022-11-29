using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstaculo : MonoBehaviour
{
    Rigidbody2D rb;
    public float vel;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Forma 1 asignandole velocidad
        //rb.velocity = new Vector2(-1, 0)*vel;
        //Forma 2 agregando fuerza
        rb.AddForce(Vector2.left*vel, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("limite"))
        {
            Destroy(gameObject);
        }
    }

}
