using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody2D rb;

    public Animator animator;

    [Header("Gameplay")]
    public float speed;

    private Vector2 movement;

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
}
