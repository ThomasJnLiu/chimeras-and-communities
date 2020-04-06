using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class clock : MonoBehaviour
{
    DateTime dt;
    public TMP_Text clockText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dt = System.DateTime.Now;
        Debug.Log(dt.ToString("hh:mm:ss"));   
        clockText.text = dt.ToString("hh:mm:ss");
    }
}
