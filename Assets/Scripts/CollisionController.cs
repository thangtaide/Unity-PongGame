using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public VecStartBall ballMovement;
    public AudioSource sound;
    void BounceFromPacket(Collision2D c)
    {
        Vector3 ballPosiotion = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        float ranketLength = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "Racket1")
        {
            x = 1;
        }
        else { x = -1; }
        float y = (ballPosiotion.y - racketPosition.y) / ranketLength;
        this.ballMovement.IncreaseSpeed();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }
    public ScoreController scoreController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            BounceFromPacket(collision);
            sound.Play();
        }
        else if (collision.gameObject.name == "WallLeft")
        {
            this.scoreController.goalPlayer1();
            this.StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            this.scoreController.goalPlayer2();
            this.StartCoroutine(this.ballMovement.StartBall(false));
        }
        else { sound.Play(); }
    }
}
