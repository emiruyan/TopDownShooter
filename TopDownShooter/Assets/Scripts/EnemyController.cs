using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerPos;//Playerımızın transform'u  
    public float speed;

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
    }
}
