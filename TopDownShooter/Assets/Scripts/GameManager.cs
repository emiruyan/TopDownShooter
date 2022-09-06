using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [HideInInspector]public int score;//int tipinde score değişkeni oluşturduk
    [SerializeField] private Text scoreText;//Ekranda yazdıracağımız scoreText'i oluşturduk
    public GameObject _gameOverPanel;//Öldüğümüzde ortaya çıkan panelimiz. PlayerController içerisinden kontrolünü sağlıyoruz.

    public void GameScore()
    {
        scoreText.text = score.ToString();//scoreText'in textini score'a eşitle ve bunu stringe çevir.
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Mevcut sahneyi tekrar yükle
    }
}
