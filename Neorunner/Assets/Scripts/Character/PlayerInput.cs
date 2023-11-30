using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody2D rb;
    //private bool isMoving = false;

    float verticalInput;
    float horizontalInput;

    float speed = 60f;
    bool facingRight = true;

    private Animator playerAnimation;
    
    

    void Start () {

        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 100;
        playerAnimation = GetComponent<Animator>();
    }

    void FixedUpdate () {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput != 0) {

            rb.AddForce(new Vector2(horizontalInput * speed, 0f));
        }

        if (horizontalInput > 0 && !facingRight) {
            Flip();
        }

        if (horizontalInput < 0 && facingRight) {
            Flip();
        }

        playerAnimation.SetFloat("speed", Mathf.Abs(rb.velocity.x));
    }


    void Flip () {

       transform.Rotate(0f, 180f, 0f);

        facingRight = !facingRight;
    }
}



    /*DiscreteMovement discretemovement;
      bool facingRight;
    void Awake () {
        discretemovement = GetComponent<DiscreteMovement>();
    }

    void Update () {
        
        //Movement
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.A)) {
            vel.x = -60;
            
        }
        else if(Input.GetKey(KeyCode.D)) {
            vel.x = 60;
            
        }
        else if(Input.GetKey(KeyCode.S)) {
            vel.y = -60;
        }
        discretemovement.MoveTransform(vel);
    }

    void Flip () {

        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
*/