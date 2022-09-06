using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private GameManager gameManager;//GameManager class'ımıza erişeceğiz.
    private Transform playerPos;//Playerımızın transform'u  
    public float speed;//Enemy' atayacağımız hızı
    public int health = 3; //Enemy health
    
    
    
    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
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
            gameManager.score++;//gameManager içerisindeki score değişkenini bir bir arttır.
            gameManager.GameScore();//gameManager içerisinde ki GameScore methodunu çalıştır.
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
