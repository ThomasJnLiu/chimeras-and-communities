using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class minimap : MonoBehaviour
{
    InputMaster controls;
    public Transform transform;
    public int size = 2;
    // Start is called before the first frame update

    private void OnEnable(){
        controls = new InputMaster();
        controls.Enable();
    }
    void Start(){
        
        transform = GetComponent<Transform>();

        // add documentation later lol
        controls.Player.OpenMap.performed += _ => OpenMap();
        controls.Player.CloseMap.performed += _ => CloseMap();
    }

    // Update is called once per frame
    void Update(){
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
        transform.localScale = new Vector3 (0.65f, 0.65f, 0.65f);
        transform.position = new Vector3 (0,0,-1);
    }
    public void CloseMap(){
        Debug.Log("close map");
        transform.localScale = new Vector3(1,1,1);
    }  
}
