using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer Renderer;

    public Sprite closeSprite;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();
        //closeSprite = Resources.Load<Sprite>("Sprites/doorClosed.png");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        Debug.Log("Clicked");
        Renderer.sprite = closeSprite;
    }

}
