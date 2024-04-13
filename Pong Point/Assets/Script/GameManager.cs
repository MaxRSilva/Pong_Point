using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //No Script do GameManager
    public Transform playerPaddle;
    public Transform enemyPaddle;
    public BallController ballController;
    

    

     void Start()
     {
        ResetGame();

     }

    public void ResetGame()
    {
        //Define as posições iniciais das raquetes 
        playerPaddle.position = new Vector3(-7f,0f,0f);
        enemyPaddle.position = new Vector3(7f, 0f, 0f);
        
        ballController.ResetBall();

    }

   

}
