using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{   
    Scene currentScene;
    string  sceneName;

    void Start () {
    currentScene = SceneManager.GetActiveScene ();
	sceneName = currentScene.name;
    }
    

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player") && sceneName == "Level 1") {

           SceneManager.LoadScene("Level 2");

        } else if (other.gameObject.CompareTag("Player") && sceneName == "Level 2") { 

            SceneManager.LoadScene("Level 3");
        
        } else if (other.gameObject.CompareTag("Player") && sceneName == "Level 3") {

            SceneManager.LoadScene("MainMenu");
        }
    }
}