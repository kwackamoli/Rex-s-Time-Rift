using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenManager : MonoBehaviour
{
    public static DeathScreenManager Instance;

    public GameObject player;
    public Canvas canvas;

    private void Awake()
    {
        Instance = this;
    }

    public void SetDeathMenu(bool state) 
    { 

        canvas.enabled = state;

        if (state)
        {
            Destroy(player);

        }

    }

}
