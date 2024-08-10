using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBoxSprite : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite openbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.pickupsCollected == 4){
            spriterenderer.sprite = openbox;
        
        }
    }
}
