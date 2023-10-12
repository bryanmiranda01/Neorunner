using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    DiscreteMovement discretemovement;
    public Rigidbody2D rb;
    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;

    void Awake () {
        discretemovement = GetComponent<DiscreteMovement>();
    }

    void Update () {
        
        //Movement
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.A)) {
            vel.x = -1;
        }
        else if(Input.GetKey(KeyCode.D)) {
            vel.x = 1;
        }
        else if(Input.GetKey(KeyCode.S)) {
            vel.y = -1;
        }
        discretemovement.MoveTransform(vel);

        //Jump
         if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }
}