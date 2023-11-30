using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    bool facingRight = true;
    public GameObject deathEffect;
    float verticalInput;
    float horizontalInput;

    public void TakeDamage (int damage) {

        health -= damage;
        
        if (health <= 0){

            Die();
        }
    }

    void FixedUpdate () {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput > 0 && !facingRight) {
            Flip();
        }

        if (horizontalInput < 0 && facingRight) {
            Flip();
        }
    }


    void Flip () {

       transform.Rotate(0f, 180f, 0f);

        facingRight = !facingRight;
    }

    void Die () {

        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
