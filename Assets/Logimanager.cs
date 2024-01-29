using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logimanager : MonoBehaviour

{
    public int playerScore;
    public Text scoreText;
    public GameObject gameover;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
         {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           }

        public void gameOver()
        {
          gameover.SetActive(true);
        }



}
