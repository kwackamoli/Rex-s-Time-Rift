using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name == "Player"){
            Score.pickupsCollected = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
