using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver(){
        transform.localScale = new Vector3 (2,2,2);
    }

    void OnMouseExit(){
        Debug.Log("exit");
        transform.localScale = new Vector3(1,1,1);
    }
}
