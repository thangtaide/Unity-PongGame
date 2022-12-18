using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VecStartBall : MonoBehaviour
{
    public float extraSpeedPerHit;
    public float movementSpeed;
    public float maxSpeed;
    // Start is called before the first frame update
    int hitCounter = 0;
    void Start()
    {
        StartCoroutine(this.StartBall());
    }
    void PositionBall(bool isStartingPlayer1)
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100,-50,0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, -50, 0);
        }
    }
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0f));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0f));
        }
    }
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.movementSpeed + this.extraSpeedPerHit * this.hitCounter;
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = dir * speed;
    }
    public void IncreaseSpeed()
    {
        if (this.hitCounter * this.extraSpeedPerHit<= maxSpeed)
        {
            this.hitCounter++;
        }
    }
}
