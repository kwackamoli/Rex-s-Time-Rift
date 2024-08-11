using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasingPlatForm : MonoBehaviour
{
    public GameObject magicplatform;
    public Sprite Frenchy;
    public Sprite NotFrenchy;
    public SpriteRenderer spriterenderer;
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
                magicplatform.SetActive(true);
                spriterenderer.sprite = Frenchy;
                StartCoroutine(buttonTimer());
        }


     }

     private IEnumerator buttonTimer(){
        yield return new WaitForSeconds(3);
        spriterenderer.sprite = NotFrenchy;
        magicplatform.SetActive(false);
     }
}
