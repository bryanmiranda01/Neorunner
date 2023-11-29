using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 10) {
            Debug.Log("Bullet has despawned");
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.CompareTag("Player")) {

            Debug.Log("Bullet has collided with players");
            Destroy(gameObject);
        }
        
    }
    
}
