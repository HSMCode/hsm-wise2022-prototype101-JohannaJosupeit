using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thefloorislava : MonoBehaviour
{
    public GameObject gameover;
    public static bool isdead;

    public void Start()
    {
        isdead = false;
        Time.timeScale = 1;
    }
    public void OnCollisionEnter(Collision collision)
    {
        gameover.SetActive(true);
        isdead = true;
        Debug.Log("Dead");
        Time.timeScale = 0;
    }
}
