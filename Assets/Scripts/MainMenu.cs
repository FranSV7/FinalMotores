using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    

    private void Start()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }


    public void QuitGame()
    {
        Application.Quit(); // Sale del juego 
    }


}
