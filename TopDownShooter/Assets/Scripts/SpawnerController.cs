using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerController : MonoBehaviour
{
    public GameObject enemyPrefab; //Çoğalacak nesnemiz
    public Transform[] spawnPoints;//Birden fazla olduğu için spawnPoints'in Transform'u dizi şeklinde oluşturduk.
    public float interval;

    private void Start()
    {
        InvokeRepeating("Spawn", 0.5f, interval); //Belirttiğimiz değerlerde tekrar tekrar çalışacak
    }

    private void Spawn()
    {
        int randPos = Random.Range(0, spawnPoints.Length); 
        //Random olarak 0 ile spawnPoints uzunluğu kadar bir değeri randPos'a atıyoruz
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[randPos].position, Quaternion.identity);
        
    }
}
