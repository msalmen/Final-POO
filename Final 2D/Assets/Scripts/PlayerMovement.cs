using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerMovement : MonoBehaviour
{

    //VARIABLES--------

    public float playerSpeed = 1;
    public float jumpForce = 30f;
    public bool isJumping = false;

    private int Health = 40;
    private float moveHorizontal;
    private float moveVertical;

    public Text hpText;

    public static event Action gameOver;

    private Rigidbody2D playerRigidbody2D;

    //START-----------

    void Start()
    {
        playerRigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        jumpForce = 30f;
        

        hpText.text = "HP: " + Health.ToString();
    }

    //UPDATE---------

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

    }

    //FIXEDUPDATE 

    private void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            playerRigidbody2D.AddForce(new Vector2(moveHorizontal * playerSpeed, 0f), ForceMode2D.Impulse);
            if (moveHorizontal > 0.1f)
                GetComponent<SpriteRenderer>().flipX = false;

            else GetComponent<SpriteRenderer>().flipX = true;

        }

        if (moveVertical > 0.1f && !isJumping)
        {
            playerRigidbody2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }

    //MECANICA DE CONTROL DE SALTO
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }

        if (collision.gameObject.GetComponent<Collectable>() != null)
        {
            //Debug.Log("Monela, no caramelo");
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

    //RECIBIR DAÑO
    public void GetDagame(int dmg)
    {
        Health -= dmg;

        hpText.text = "HP: "+ Health.ToString();

        if (Health <= 0)
        {
            Debug.Log(" Estoy muerto");
            gameOver?.Invoke();
            Destroy(this.gameObject);
        }

    }

    
}
