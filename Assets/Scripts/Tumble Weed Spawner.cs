using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleWeedSpawner : MonoBehaviour
{
    public float maxCoolDown;

    private float coolDown = 0;

    public GameObject tumbleWeed;

        
    

    // Update is called once per frame
    void Update()
    {
        coolDown += Time.deltaTime;

        if (coolDown >= maxCoolDown )
        {
            coolDown = 0;
            SpawnTumbleWeed();

        }
    }
    private void SpawnTumbleWeed()
    {
        GameObject tumbleWeedObject = Instantiate( tumbleWeed );

        Rigidbody2D rb = tumbleWeedObject.GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(5,0),ForceMode2D.Impulse);

    }

}
