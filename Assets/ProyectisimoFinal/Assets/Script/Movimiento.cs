using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
    }

    void MovimientoJugador()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX,0,movY) * speed * Time.deltaTime);
    }
}
