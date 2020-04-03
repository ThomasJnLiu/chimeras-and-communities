using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationNode : MonoBehaviour
{
    public int indexA, indexB;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        scr_TextManager.instance.ShowTextbox(indexA, indexB, delay);
    }
}
