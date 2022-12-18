using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour
{
    public Text playerWin;
    // Update is called once per frame
    private void Start()
    {
        if (ScoreController.IsPlayer1Win())
        {
            playerWin.text = "Player 1 Wins";
        }
        else
        {
            playerWin.text = "Player 2 Wins";
        }
    }
}
