using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mapManager : MonoBehaviour
{
    InputMaster mapControls;

    public GameObject minimap, map;
    void Awake(){
        mapControls = new InputMaster();
        mapControls.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        mapControls.Player.OpenMap.performed += _ => OpenMap();
        mapControls.Player.CloseMap.performed += _ => CloseMap();

        minimap.SetActive(true);
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenMap(){
        minimap.SetActive(false);
        map.SetActive(true);
    }

    void CloseMap(){
        minimap.SetActive(true);
        map.SetActive(false);
    }
}
