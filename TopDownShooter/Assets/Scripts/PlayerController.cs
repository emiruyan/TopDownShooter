using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private EnemyController _enemyController;//EnemyController classımıza eriştik
    private GameManager _gameManager;//GameManager classımıza eriştik
    
    [Header("Components")]
    public Rigidbody2D rb;

    public Animator animator;

    [Header("Gameplay")]
    public float speed;

    public int playerHealth = 10;

    private Vector2 movement;

    //[Header("Canvas")]
    //public GameObject _gameOverPanel;
    

    private void Start()
    {
        Time.timeScale = 1;//Play again bastıktan sonra tekrardan timeScale aktif ediyoruz.
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        //Movement'ı Unity içerisinde Axis ile atayacağız.
        movement.x = Input.GetAxis("Horizontal"); //GetAxsHrzntl'ı movement.x'e atadık
        movement.y = Input.GetAxis("Vertical"); //GetAxsVrtcl'ı movement.y'e atadık

        rb.velocity = new Vector2(//Vector2 değerlerini rb.velocity'e atadık
            movement.x * speed,
            movement.y * speed
        );

        RunAnim();
    }

    private void RunAnim()
    {
        if (movement.x != 0 || movement.y != 0)//movement x.y 0'a eşit değil ise;
        {
            animator.SetBool("isRunning" , true);//koşuyorsa true
        }
        else
        {
            animator.SetBool("isRunning", false);//koşmuyorsa false
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")//Çarpan objenin tag'ı "Enemy"ise
        {
           TakeDamage();
            
            if (playerHealth == 0) //playerHealth 0'a eşit ise
            {
                Time.timeScale = 0;//Oyunu durdur
                _gameManager._gameOverPanel.SetActive(true);//_gameManager içerisindeki gameOverPanel'i true'a çek
            }
        }
    }
    
    
    private void TakeDamage()
    {
        playerHealth--;//playerHealth bir bir azalsın

    }
    
    
}
