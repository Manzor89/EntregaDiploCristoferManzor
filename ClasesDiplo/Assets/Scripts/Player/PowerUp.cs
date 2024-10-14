using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed = 3.0f;
   

 void Start()
    {
        // Inicializaci�n si es necesario
    }

 void Update()
    {
        // Actualizaci�n com�n para todos los enemigos
        Move();
    }

 void Move()
    {
        // Movimiento simple hacia abajo (puedes personalizarlo seg�n tu juego)
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.Translate(speed * Time.deltaTime * new Vector3(Mathf.Sin(Time.time * 1.5f), -1, 0));
    }


}