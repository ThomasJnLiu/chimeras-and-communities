using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapNode : MonoBehaviour
{
    public GameObject location;

    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color (0,0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseEnter(){
        renderer.color = new Color (0,0,0,0.5f);
    }
    void OnMouseExit(){
        renderer.color = new Color (0,0,0,0);
    }

    void OnMouseDown(){
        location.SetActive(true);
    }
    
}
