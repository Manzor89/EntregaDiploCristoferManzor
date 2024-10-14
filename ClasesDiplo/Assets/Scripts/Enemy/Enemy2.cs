using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float speed = 8.0f;
    public int health = 2;
    public GameObject explosionPrefab;

    protected virtual void Start()
    {
        // Inicialización si es necesario
    }

    protected virtual void Update()
    {
        // Actualización común para todos los enemigos
        Move();
    }

    protected void Move()
    {
        // Movimiento simple hacia abajo (puedes personalizarlo según tu juego)
        //transform.Translate(Vector3.down * speed * Time.deltaTime);
        transform.Translate(new Vector3(Mathf.Sin(Time.time * 1.5f), -1, 0) * speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}