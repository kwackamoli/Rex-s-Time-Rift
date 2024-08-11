using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TumbleWeed : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Score.pickupsCollected = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TumbleWeedDestroyer") 

        {
            Destroy(gameObject);
        }
    }
}
