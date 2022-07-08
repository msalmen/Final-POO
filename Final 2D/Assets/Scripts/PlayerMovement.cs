using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Health = 3;
    public float playerSpeed = 1;
    public float jumpForce = 30f;
    public bool isJumping = false;

    private float moveHorizontal;
    private float moveVertical;



    private Rigidbody2D playerRigidbody2D;

    
    void Start()
    {
        playerRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        jumpForce = 30f;
    }

    
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        
    }

    

    private void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            playerRigidbody2D.AddForce(new Vector2(moveHorizontal * playerSpeed, 0f), ForceMode2D.Impulse);
        }
        
        if (moveVertical > 0.1f && !isJumping)
        {
            Debug.Log("intentando saltar");
            playerRigidbody2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }

        if (collision.gameObject.GetComponent<Collectable>()!=null) 
        {
            Debug.Log("toque una moneda");
            collision.gameObject.GetComponent<Collectable>().colect();
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }        
    }


    public void getDagame(int dmg)
    {
        Health -= dmg;
        if (Health <= 0)
        {
            Debug.Log(" Estoy muerto");
        }
    }
}
