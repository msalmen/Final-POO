using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Tooltip("Player speed")]
    public float pSpeed = 3;
    public float jForce = 1;
    public bool croach;
    public bool alive;





    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float mov_x = Input.GetAxis("Horizontal");
        float mov_y = Input.GetAxis("Jump");

        transform.position += new Vector3(mov_x, mov_y * jForce, 0) * Time.deltaTime * pSpeed;

        
        /* if (Input.GetKeyDown("Jump"))
        {
            mov_y = 1;
            transform.position += new Vector3(mov_x, mov_y * jForce, 0) * Time.deltaTime * pSpeed;
        } 
        else 
        {
            transform.position += new Vector3(mov_x, mov_y * jForce, 0) * Time.deltaTime * pSpeed;
        }*/
        
    }
}
