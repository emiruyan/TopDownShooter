using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Vector2 target;

    public float speed;

    private void Start()
    {
        //mousePosition'u ScrnToWrldPoint aracılığı ile target'a atadık
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {//Vector2 değerlerini transform.positiona atadık.
        transform.position = Vector2.MoveTowards(
        transform.position,
        target,
        speed * Time.deltaTime
        );
        
        Destroy(gameObject, 2f);//Mermileri belirli bir süre sonra yok ediyoruz.
    }
}
