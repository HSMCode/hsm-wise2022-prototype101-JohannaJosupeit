using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int diceNumber;
    public int diceSides = 50;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        diceNumber = Random.Range(1, diceSides);
        Debug.Log("You rolled a " + diceNumber);

        //if the rolled number is smaller than 9
        if (diceNumber < 9) 
        {   //you win
            source.PlayOneShot(clip);
            Debug.Log("You win");
            
        }
        //if not, you loose
        else
        {
            Debug.Log("You loose");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
