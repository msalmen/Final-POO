using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosca : Enemigos
{
    [SerializeField] private float minimum, maximum;
    [SerializeField] private float index;

    static float t=0.0f;    

    

    
    void FixedUpdate()
    {
        transform.position += new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);
        t += index * Time.deltaTime;


        if (t>1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;            
        }
        
    }
    
    

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        Debug.Log("Jugador recibe daño");
    }
}
