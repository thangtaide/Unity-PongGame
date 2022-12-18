using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2AI : MonoBehaviour
{
    public float speedMovement;
    public GameObject ball;
    private void FixedUpdate()
    {
        if (Mathf.Abs(this.gameObject.transform.position.y - ball.transform.position.y) >= 40)
        {
            if(this.gameObject.transform.position.y > ball.transform.position.y)
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speedMovement;
            }
            else
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speedMovement;
            }
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
