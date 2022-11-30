using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class TriggerGoal : MonoBehaviour
{
    public ParticleSystem source;
    
   
    
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("You win!");
        source.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
