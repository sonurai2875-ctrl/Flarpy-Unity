using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Logicmanager : MonoBehaviour
{
 public AudioSource audioSource;
 public TMP_Text scoreText;
 public int playerScore;
 public GameObject GameOverScreen;

 void Awake()
 {
    if (audioSource == null)
    {
       audioSource = GetComponent<AudioSource>();
    }
 }

 [ContextMenu("Add Score")]
 public void addScore(int scoreToAdd=1){
    
     playerScore += scoreToAdd;
     scoreText.text =  playerScore.ToString();
    if (audioSource != null && audioSource.clip != null)
    {
       audioSource.Play();
    }
 }
 public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
 public void GameOver(){
    GameOverScreen.SetActive(true);
    
 }
}