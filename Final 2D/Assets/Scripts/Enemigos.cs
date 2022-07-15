using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigos : MonoBehaviour
{
    [SerializeField]protected ScriptableEnemy EnemyData;
    private int daño;

    private void Awake()
    {
        daño = EnemyData.Daño;
        daño *= 2;
    }



    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().GetDagame(EnemyData.Daño);
            Debug.Log("hice daño" + daño);
        }
    }

    

}
