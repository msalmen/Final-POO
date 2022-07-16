using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bandera : MonoBehaviour
{
    public static event Action youWin;  
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            youWin?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
