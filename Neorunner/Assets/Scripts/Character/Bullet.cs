using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private float timer;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5) {

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hit) {
        Destroy(gameObject);
    }
     
}
