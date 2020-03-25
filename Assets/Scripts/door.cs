using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer Renderer;

    public Sprite closeSprite;
    public Sprite openSprite;
    // Start is called before the first frame update

    bool open = false; 

    int counter = 0;
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
        counter++;
        Debug.Log(counter);

        
        if(open){
            open = false;
            Renderer.sprite = closeSprite;
        }else{
            open = true;
            Renderer.sprite = openSprite;
        }

    }

}
