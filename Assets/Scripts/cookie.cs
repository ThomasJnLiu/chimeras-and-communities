using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!cookieManager.instance.gameRunning){
            Destroy(gameObject);
        }
    }

    void OnMouseDown(){
        cookieManager.instance.Increment();
        Destroy(gameObject);
        JSAM.AudioManager.instance.PlaySoundOnce("crunch");
    }
}
