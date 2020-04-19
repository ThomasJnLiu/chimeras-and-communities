using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    public SpriteRenderer scrim;
    public door door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        this.gameObject.SetActive(false);
        scrim.color = new Color (0,0,0,0);
        door.open = false;
    }
}
