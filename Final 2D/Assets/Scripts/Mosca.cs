using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosca : Enemigos
{
    [SerializeField]
    private float offset1, offset2;
    public float t;
    
    

    

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position += new Vector3(Mathf.Lerp(offset1, offset2, t), 0, 0);
        t += 0.1f * Time.deltaTime;


        if (t>1.0f)
        {

            float temp = offset2;
            offset2 = offset1;
            offset1 = temp;
            t = 0.0f;
        }
        */
    }
    
    

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        Debug.Log("Jugador recibe daño");
    }
}
