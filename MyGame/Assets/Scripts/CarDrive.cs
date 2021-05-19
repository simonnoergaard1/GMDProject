using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDrive : MonoBehaviour
{

    public float speed;
    public float turnspeed;
    public float gravity;
    public AudioSource[] soundFX;
 
    
    private Rigidbody rb1;
    public static CarDrive instance;
    
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
        {
            soundFX[0].Play();
        }
        
        

    }

    // FixedUpdate is more smooth than regular update
    void FixedUpdate()
    {
      Move();
      Turn();
      Fall();
      RestartGame();
    }
    

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //RelativeForce to much in the direction we are facing
            rb1.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * speed);
            

        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            //RelativeForce to much in the direction we are facing
            rb1.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * -speed);
        }

        Vector3 localVelocity = transform.InverseTransformDirection(rb1.velocity);
        localVelocity.x = 0;
        rb1.velocity = transform.TransformDirection(localVelocity);
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //RelativeForce to much in the direction we are facing
            rb1.AddTorque(Vector3.up * turnspeed);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            //RelativeForce to much in the direction we are facing
            rb1.AddTorque(-Vector3.up * turnspeed);
        } 
    }

    void Fall()
    {
        rb1.AddForce(Vector3.down * gravity );
    }

    void RestartGame()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Stop()
    {
        speed = 0;
        turnspeed = 0;
    }

    public void Restart()
    {
        speed = 60;
        turnspeed = 20;
    }
    
    
}
