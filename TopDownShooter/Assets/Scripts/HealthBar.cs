using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   private PlayerController _playerController;//PlayerController classını bağladık
   public Image healthBar;
   public float currentHealth;
   public float maxHealth;

   private void Start()
   {
      _playerController = GameObject.FindObjectOfType<PlayerController>();//PlayerController classını bağladık
      
   }

   private void Update()
   {
      currentHealth = _playerController.playerHealth;//playerHealth'i currentHealth'e atadık
      healthBar.fillAmount = currentHealth / maxHealth;//currentHealth ve maxHealth'i bölüp healthBar'ın fillAmonut'una atadık.
   }
}
