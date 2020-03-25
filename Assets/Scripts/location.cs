using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class location : MonoBehaviour
{
    public string area;
    public Collider2D collider;
    public SpriteRenderer spRenderer;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver(){

    }
}
