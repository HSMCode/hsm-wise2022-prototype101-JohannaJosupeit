using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryVariables : MonoBehaviour
{
    private int problems;
    public float PlayerSpeed;
    public double WillToLive;
    public string PlayerName;
    public bool IsAlive = true;
    public int a = 7;
    public int b = 80;
    public int c = -4;
    public int d = -1;
    public int e = 20;
    public int f;
    // Start is called before the first frame update
    void Start()
    {
        problems = 1416/3;
        PlayerSpeed = 2.7f;
        WillToLive = 0.1;
        f = (a + b + c + d + e)/3;
        Debug.Log(f);
        Debug.Log("There are " + problems +" problems.");
        Debug.Log("Will to live is currently at " + WillToLive + "%.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
