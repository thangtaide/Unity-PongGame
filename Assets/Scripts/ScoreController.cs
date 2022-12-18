using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    private static bool isPlayer1Win = false;
    public GameObject textScorePlayer1;
    public GameObject textScorePlayer2;
    public int goalToWin;
    public int sceneNumber;
    private void Start()
    {
        scorePlayer1 = 0;
        scorePlayer2 = 0;
    }
    private void Update()
    {
        if(scorePlayer1>= this.goalToWin)
        {
            isPlayer1Win = true;
            SceneManager.LoadScene(sceneNumber);
        }else if (scorePlayer2 >= this.goalToWin)
        {
            isPlayer1Win = false;
            SceneManager.LoadScene(sceneNumber);
        }
    }
    private void FixedUpdate()
    {
        Text uiPlayer1 = this.textScorePlayer1.GetComponent<Text>();
        Text uiPlayer2 = this.textScorePlayer2.GetComponent<Text>();
        uiPlayer1.text = scorePlayer1.ToString();
        uiPlayer2.text = scorePlayer2.ToString();
    }
    public void goalPlayer1()
    {
        scorePlayer2++;
    }
    public void goalPlayer2()
    {
        scorePlayer1++;
    }
    public static bool IsPlayer1Win()
    {
        return isPlayer1Win;
    }
}
