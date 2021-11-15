using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("House1");
    }

    public void exitGame(){
        Application.Quit();
    }
}
