using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mapManager : MonoBehaviour
{
    public static mapManager instance;
    InputMaster mapControls;

    public GameObject minimap, map;
    public bool mapOpen = false;
    void Awake(){
        mapControls = new InputMaster();
        mapControls.Enable();

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            // A unique case where the Singleton exists but not in this scene
            if (instance.gameObject.scene.name == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        mapControls.Player.OpenMap.performed += OpenMap;
        mapControls.Player.CloseMap.performed += _ => CloseMap();
        mapControls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());

        minimap.SetActive(true);
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move(Vector2 direction){
        Debug.Log(direction);
    }
    void OpenMap(InputAction.CallbackContext context){
        Debug.Log(context);
        minimap.SetActive(false);
        map.SetActive(true);

        mapOpen = true;
    }

    void CloseMap(){
        minimap.SetActive(true);
        map.SetActive(false);

        mapOpen = false;
    }
}
