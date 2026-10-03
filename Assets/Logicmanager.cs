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
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
 }
 public void QuitGame(){
    Time.timeScale = 1f;
    Application.Quit();
 }
 public void GoToMainMenu(){
    Time.timeScale = 1f;
    SceneManager.LoadScene("MainMenu");
 }
 public void GameOver(){
    Time.timeScale = 0f;
    GameOverScreen.SetActive(true);
    
 }
}