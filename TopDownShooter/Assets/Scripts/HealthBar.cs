using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   private PlayerController _playerController;
   public Image healthBar;
   public float currentHealth;
   public float maxHealth;

   private void Start()
   {
      _playerController = GameObject.FindObjectOfType<PlayerController>();
      
   }

   private void Update()
   {
      currentHealth = _playerController.playerHealth;
      healthBar.fillAmount = currentHealth / maxHealth;
   }
}
