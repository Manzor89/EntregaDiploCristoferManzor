using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;  // Prefab del enemigo
    public float spawnTime = 1.5f;  // Tiempo entre spawns
    private float time = 0.0f;      // Tiempo transcurrido (debería ser private para encapsular mejor)
    public Player player;
    public TextMeshProUGUI liveText;
    public TextMeshProUGUI WeaponText;

    [Header("UI")]
    public Image BulletImage;
    public List<Sprite> bulletSprites;

    // Update is called once per frame
    void Update()
    {
        CreateEnemy();  // Llamada funcion CreateEnemy
        UpdateCanvas();
        changeBulletImage(player.actualWeapon);
      
        //TotalTime += Time.deltaTime;
    }

    public void changeBulletImage(int index)
    {
        Debug.Log("ChangeBulletImage:" + index);
        BulletImage.sprite = bulletSprites[index];
    }
    void UpdateCanvas()
    {
        liveText.text = "Life: " + player.lives;
        WeaponText.text = player.BulletPref.name;
    }




    private void CreateEnemy()
    {
        time += Time.deltaTime;  // Aumenta el tiempo transcurrido
        if (time > spawnTime)    // Si ha pasado más tiempo que el tiempo de spawn...
        {
            // Instancia el enemigo en una posición aleatoria dentro de un rango
            Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 7.0f, 0), Quaternion.identity);
            time = 0.0f;  // Reinicia el contador de tiempo
        }
    }

   
    }


