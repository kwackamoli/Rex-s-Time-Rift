using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string sceneName;

    public void LoadGame()
    {
        // Debug.Log("Loading Game");
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //Debug.Log("Quitting Game");
        Application.Quit();
    }
}
