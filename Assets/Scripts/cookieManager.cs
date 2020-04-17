using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieManager : MonoBehaviour
{
    public static cookieManager instance;
    public GameObject cookie;

    public int counter = 0;

    public bool gameRunning = true;

    public float xPos, yPos, xPos2, yPos2;
    public Vector2 cookiePosition, cookiePos2; 

    void Awake(){
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
        gameRunning = true;
                    StartCoroutine ("SpawnCookie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Increment(){
        counter++;
    }

    IEnumerator SpawnCookie(){
        if(gameRunning){
            xPos = Random.Range(-7,7);
            yPos = Random.Range(-2.5f,2.5f);

                        xPos2 = Random.Range(-7,7);
            yPos2 = Random.Range(-2.5f,2.5f);
            
            cookiePosition = new Vector2(xPos, yPos);
            cookiePos2 = new Vector2(xPos2, yPos2);
            
            yield return new WaitForSeconds(0.7f);
            
            Instantiate(cookie, cookiePosition, Quaternion.identity);
            Instantiate(cookie, cookiePos2, Quaternion.identity);

            StartCoroutine ("SpawnCookie");
        }
    }
}
