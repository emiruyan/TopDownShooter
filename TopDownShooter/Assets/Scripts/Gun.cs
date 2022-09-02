using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Vector3 mousePos;//mousePozisyonu Vector3 olarak tutacağız
    public GameObject cross;
    public GameObject bullet;

    private void Update()
    {//Mouse hareketlerine buradan erişeceğiz.
        //Tıkladığımız noktaya erişmek için ScrnToWrldPoint'e Vector3 değerlerini girdik. Ve bu değerleri mousePos'a atadık.
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
        Input.mousePosition.x,
        Input.mousePosition.y,
        transform.position.z
        ));

        //Crosshair ile mousePos'u bağladık.
        cross.transform.position = new Vector3(
        mousePos.x,
        mousePos.y,
        transform.position.z
        );

        if (Input.GetMouseButtonDown(0))//Mouse sol click tıklanır ise;
        {
            Shot();
        }

        Vector3 targetDirection = mousePos - transform.position;
        float rotateZ = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;//Tanjant olarak aldığımız değeri çeviriyoruz.
        transform.rotation = Quaternion.Euler(0f,0f,rotateZ);
        //Silahımızı döndürme işlemini Euler ile yaptık ve bunu transform.rotation'a atadık.
    }

    private void Shot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);//Mermilerimi çoğaltıyoruz
    }
}
