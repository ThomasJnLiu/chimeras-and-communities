using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cookieManager : MonoBehaviour
{
    public static cookieManager instance;
    public GameObject cookie;

    public int counter = 0;

    public bool gameRunning = true;

    public float[] xPosition, yPosition; 
    public Vector2[] cookiePos;

    public Text scoreText, timerText;
    public float timer = 20f;
    double timer2;
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
        if(timer > 0){
            timer -= Time.deltaTime;
            timer2 = System.Math.Round(timer, 2);
            timerText.text = timer2.ToString();
        }else{
            timer = 0; 
            timer2 = System.Math.Round(timer, 2);
            timerText.text = timer2.ToString();
            gameRunning = false;
        }


        
    }

    public void Increment(){
        counter++;
        scoreText.text = counter.ToString();
    }

    IEnumerator SpawnCookie(){
        if(gameRunning){

            for (int i = 0; i < 3; i++){
                xPosition[i] = Random.Range(-7f, 7f);
                yPosition[i] = Random.Range(-2.5f, 2.5f);

                cookiePos[i] = new Vector2 (xPosition[i], yPosition[i]); 
                Instantiate(cookie, cookiePos[i], Quaternion.identity);
            }
            yield return new WaitForSeconds(0.7f);
            

            StartCoroutine ("SpawnCookie");
        }
    }
}
