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

    public SpriteRenderer scrim;
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
        //checks map state, prevents interaction when map is open
        if(!mapManager.instance.mapOpen){
            counter++;
            Debug.Log(counter);

            JSAM.AudioManager.instance.PlaySoundOnce("fridge");
            if(open){
                open = false;
                Renderer.sprite = closeSprite;
                scrim.color = new Color (0,0,0,0);
                
            }else{
                open = true;
                Renderer.sprite = openSprite;
                scrim.color = new Color (0,0,0,0.5f);
            }
        }
    }

}
