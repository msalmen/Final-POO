using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinches : Enemigos
{
    protected override void Test()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        Debug.Log("Jugador muerto");
    }
}
