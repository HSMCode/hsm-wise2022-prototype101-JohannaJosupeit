using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour

{
    public float playerSpeed;
    Rigidbody robot;
    float rotationy;
    
    // Start is called before the first frame update
    void Start()
    {   
        robot = GetComponent<Rigidbody>();
        playerSpeed = 5f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("space"))
        {
            robot.velocity = new Vector3(0, 5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
           
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }

    }
}
