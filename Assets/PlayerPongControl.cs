using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPongControl : MonoBehaviour
{
    Vector3 mousePos;
    public float minY,maxY;
    void Start()
    {
        
    }

    void Update()
    {
        mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        float posYlimited = Mathf.Clamp(mousePos.y, minY, maxY);
        transform.position = new Vector3(transform.position.x,posYlimited,0);
    }
}
