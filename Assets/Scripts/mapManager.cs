using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class mapManager : MonoBehaviour
{
    public static mapManager instance;
    InputMaster mapControls;

    public GameObject minimap, map, currentLocation;
    public bool mapOpen = false;
    public GameObject[] locations;
    public SpriteRenderer scrim;
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
        JSAM.AudioManager.instance.PlayMusic("roomMusic");

        mapControls.Player.OpenMap.performed += OpenMap;
        mapControls.Player.CloseMap.performed += _ => CloseMap();
        mapControls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());

        //minimap.SetActive(true);
        map.SetActive(false);

        locations = GameObject.FindGameObjectsWithTag("Location");
        scrim.color = new Color (0,0,0,0);

        foreach(GameObject location in locations){
            location.SetActive(false);
        }

        currentLocation.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move(Vector2 direction){
        Debug.Log(direction);
    }
    void OpenMap(InputAction.CallbackContext context){
        minimap.SetActive(false);
        map.SetActive(true);

        mapOpen = true;

        scrim.color = new Color (0,0,0,0.5f);
    }

    void CloseMap(){
        //minimap.SetActive(true);
        map.SetActive(false);

        mapOpen = false;

        scrim.color = new Color (0,0,0,0);
    }

    public void ChangeLocation(GameObject newLocation){
        foreach(GameObject location in locations){
            location.SetActive(false);
        }

        currentLocation = newLocation;
    }
}
