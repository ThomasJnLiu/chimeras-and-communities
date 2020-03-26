using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        // if(Input.GetKeyDown("up")){
        //     Debug.Log("fire");
        // }
    }

    void OnMouseOver(){
        transform.localScale = new Vector3 (2,2,2);
    }

    void OnMouseExit(){
        Debug.Log("exit");
        transform.localScale = new Vector3(1,1,1);
    }

    public void OpenMap(){
        Debug.Log("open map");
        transform.localScale = new Vector3 (2,2,2);
    }
public void CloseMap(){
    Debug.Log("close map");
    transform.localScale = new Vector3(1,1,1);
}
    
}
