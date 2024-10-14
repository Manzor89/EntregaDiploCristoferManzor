using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPowerUp : MonoBehaviour
{
    public GameObject PowerUpPrefab; // Prefab del Power-Up
    public float spawnTimeMin = 10f;  // Tiempo m�nimo entre spawns
    public float spawnTimeMax = 20f;  // Tiempo m�ximo entre spawns
    private float time = 0.0f;        // Contador de tiempo
    private float nextSpawnTime;      // Tiempo para el pr�ximo spawn

    void Start()
    {
        // Establecer el tiempo inicial de spawn aleatorio
        nextSpawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        PowerUp();
    }

    private void PowerUp()
    {
        time += Time.deltaTime;  // Aumenta el tiempo transcurrido

        if (time >= nextSpawnTime)    // Si ha pasado m�s tiempo que el tiempo de spawn...
        {
            // Instancia el PowerUpPrefab en una posici�n aleatoria dentro de un rango
            Instantiate(PowerUpPrefab, new Vector3(Random.Range(-5.0f, 8.0f), 6.0f, 0), Quaternion.identity);

            // Reinicia el contador de tiempo
            time = 0.0f;

            // Generar un nuevo tiempo de spawn aleatorio para la pr�xima aparici�n
            nextSpawnTime = Random.Range(spawnTimeMin, spawnTimeMax);

            // Debug para confirmar el spawn
            Debug.Log("PowerUp instanciado, pr�ximo spawn en: " + nextSpawnTime + " segundos.");
        }
    }
}
