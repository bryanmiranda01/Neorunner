using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Enemy")) {

            
            SceneManager.LoadScene("MainMenu");
            Destroy(gameObject); 

        }
    }
}