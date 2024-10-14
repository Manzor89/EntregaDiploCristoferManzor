using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedBoostAmount = 5f; // Cuánto se incrementará la velocidad
    public float duration = 5f;         // Cuánto tiempo durará el efecto

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el objeto que colisiona es el jugador (tag "Player")
        if (collision.CompareTag("Player"))
        {
            // Obtener el script del jugador (PlayerController) y aumentar la velocidad
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                // Iniciar el aumento de velocidad en el jugador
                player.IncreaseSpeed(speedBoostAmount, duration);

                // Destruir el power-up después de recogerlo
                Destroy(gameObject);
            }
        }
    }
}
