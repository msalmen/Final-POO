using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinches : Enemigos
{
       
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        Debug.Log("Jugador recibe daño");
    }
}
