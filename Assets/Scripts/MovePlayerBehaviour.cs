using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerBehaviour : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0f,moveVertical);
        myrigidbody.velocity = movement*speed;
    }
}
