using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapNode : MonoBehaviour
{
    public string location;

    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseOver(){
        Debug.Log("rollover");
        renderer.color = new Color (0,0,0,0.0f);
    }
    
}
