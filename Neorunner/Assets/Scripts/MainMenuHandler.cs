using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void PlayGame(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Level 1");
        
    }

    public void QuitGame(){
        Debug.Log("Quit functions");
        Application.Quit();
    }
}
