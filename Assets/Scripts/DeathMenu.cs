using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public string mainMenuName;

    public string currentSceneName;

    public void RestartLevel()
    {
       
        SceneManager.LoadScene(currentSceneName);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(mainMenuName);
        

    }
 
        
    
}
