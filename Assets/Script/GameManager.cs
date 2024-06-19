using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //No Script do GameManager
    public Transform playerPaddle;
    public Transform enemyPaddle;
    public BallController ballController;
    public int winPoints = 2;
    public int playerScore = 0;
    public int enemyScore = 0;
   
    public TextMeshProUGUI textPointsPlayer;
    public TextMeshProUGUI textPointsEnemy;
    public GameObject screenEndGame;

    public TextMeshProUGUI textEndGame;

    void Start()
     {
        ResetGame();

     }

    public void ResetGame()
    {
        //Define as posições iniciais das raquetes 
        playerPaddle.position = new Vector3(30f,0f,0f);
        enemyPaddle.position = new Vector3(-30f, 0f, 0f);
        
        ballController.ResetBall();

        playerScore = 0;    
        enemyScore = 0;

        textPointsEnemy.text = enemyScore.ToString();
        textPointsPlayer.text = playerScore.ToString();
    
        screenEndGame.SetActive(false);
    }

   public void ScorePlayer()
   {
        playerScore ++;
        textPointsPlayer.text = playerScore.ToString();
        CheckWin();
   }
    public void ScoreEnemy()
    {
        enemyScore++;
        textPointsEnemy.text = enemyScore.ToString();
        CheckWin();

    }
    public void CheckWin()
    {
        if (enemyScore >= winPoints || playerScore >= winPoints)
        {
            //ResetGame();
            EndGame();
        }
    }
    public void EndGame()
    {
        //screenEndGame.SetActive(true);
        //dentro do método EndGame
        //textEndGame.text = "Vitória " + SaveController.Instance.GetName(playerScore > enemyScore);
        //Invoke("LoadMenu", 2f);

        screenEndGame.SetActive(true);
        string winner = SaveController.Instance.GetName(playerScore > enemyScore);
        textEndGame.text = "Vitória " + winner;
        SaveController.Instance.SaveWinner(winner);
        
        Invoke("LoadMenu", 2f);

    }
    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }


}
