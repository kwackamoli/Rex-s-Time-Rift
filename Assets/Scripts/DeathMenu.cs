using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public string mainMenuName;


    public void RestartLevel()
    {
       
       // SceneManager.LoadScene(currentSceneName);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(mainMenuName);
        

    }
 
        
    
}
