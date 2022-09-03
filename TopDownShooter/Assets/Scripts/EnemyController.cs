using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform playerPos;//Playerımızın transform'u  
    public float speed;//Enemy' atayacağımız hızı
    private int health = 3; //Enemy health
    // private int score;
    // public Text scoreText;
    
    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //Player tagı aracılığı ile player'ın transformuna erişeceğiz
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(
        transform.position,//enemy'nin kendi pozisyonu
        playerPos.position,//hedef playerın pozisyonu
        speed * Time.deltaTime
        );

        if (health <= 0)//Enemy health'i 0'a küçük eşit ise
        {
            Destroy(gameObject);//Enemy'i yok et
            // score++;
            // scoreText.text = score.ToString();

            
        }
    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")//Çarpan nesnenin tagı "Bullet" ise;
        {
            health--; //Health bir bir azalsın
        }
    
    }
}
