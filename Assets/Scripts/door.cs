using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer Renderer;

    public Sprite closeSprite;
    public Sprite openSprite;
    public bool fridge;
    public GameObject fridgeOpen;
    // Start is called before the first frame update

    public bool open = false; 

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
                if(fridge){
                    fridgeOpen.SetActive(false);
                }else{
                    Renderer.sprite = closeSprite;
                }
                
                scrim.color = new Color (0,0,0,0);
                
            }else{
                Debug.Log("oepne");
                open = true;
                if(fridge){
                    fridgeOpen.SetActive(true);
                }else{
                    Renderer.sprite = closeSprite;
                }                
                scrim.color = new Color (0,0,0,0.5f);
            }
        }
    }

}
