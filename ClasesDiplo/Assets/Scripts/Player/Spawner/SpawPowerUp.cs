using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawPowerUp : MonoBehaviour
{
    public GameObject PowerUpPrefab; // Prefab del Power-Up
    public float spawnTimeMin = 10f;  // Tiempo mínimo entre spawns
    public float spawnTimeMax = 20f;  // Tiempo máximo entre spawns
    private float time = 0.0f;        // Contador de tiempo
    private float nextSpawnTime;      // Tiempo para el próximo spawn

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

        if (time >= nextSpawnTime)    // Si ha pasado más tiempo que el tiempo de spawn...
        {
            // Instancia el PowerUpPrefab en una posición aleatoria dentro de un rango
            Instantiate(PowerUpPrefab, new Vector3(Random.Range(-5.0f, 8.0f), 6.0f, 0), Quaternion.identity);

            // Reinicia el contador de tiempo
            time = 0.0f;

            // Generar un nuevo tiempo de spawn aleatorio para la próxima aparición
            nextSpawnTime = Random.Range(spawnTimeMin, spawnTimeMax);

            // Debug para confirmar el spawn
            Debug.Log("PowerUp instanciado, próximo spawn en: " + nextSpawnTime + " segundos.");
        }
    }
}
