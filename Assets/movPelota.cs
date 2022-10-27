using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPelota : MonoBehaviour
{
    Rigidbody2D rbPelota;
    // Start is called before the first frame update
    void Start()
    {
        rbPelota = GetComponent<Rigidbody2D>();
        rbPelota.velocity = new Vector2(1, 0);
    } //subscribe to tboxfinn  y a drolejan :)

    // Update is called once per frame
    void Update()
    {
        
    }
}
