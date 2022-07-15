using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigos : MonoBehaviour
{
    [SerializeField]protected ScriptableEnemy EnemyData;
    private int da�o;

    private void Awake()
    {
        da�o = EnemyData.Da�o;
        da�o *= 2;
    }



    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().GetDagame(EnemyData.Da�o);
            Debug.Log("hice da�o" + da�o);
        }
    }

    

}
