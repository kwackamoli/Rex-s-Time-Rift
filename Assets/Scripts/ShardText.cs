using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShardText : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Clock Shards collected: " + Score.pickupsCollected.ToString() + "/4";
    }
}
