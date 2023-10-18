using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rb;
   private bool isJumping;

   public float jump;

   void Start () {

    rb = GetComponent<Rigidbody2D>();

   }

   void FixedUpdate() {

    rb.AddForce(Physics.gravity*rb.mass);
   }
   
   void Update() {
        Vector3 vel = Vector3.zero;

        if(Input.GetKeyDown(KeyCode.W) && !isJumping) {
            
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
   }

   void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.CompareTag("Floor")){

            isJumping = false;
        }
   }
}
