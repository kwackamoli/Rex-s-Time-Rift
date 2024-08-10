using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float speed = 20f;
    public float jumpspeed = 30f;
    public bool isgrounded;
    public LayerMask groundMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            rigidbody.AddForce(transform.right*-speed);

        }
        else if (Input.GetKey(KeyCode.D)){
            rigidbody.AddForce(transform.right*speed);
        }
        if (Input.GetKeyDown(KeyCode.W) && isgrounded){
            
            rigidbody.AddForce(transform.up*jumpspeed,ForceMode2D.Impulse);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 0.6f, groundMask);
        if(hit.collider != null){
            isgrounded = true;

        }else{
            isgrounded = false;
        }
    }
}