using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigos : MonoBehaviour, Collectable
{
    [SerializeField]protected int damage;

    public void colect()
    {
        Debug.Log("Estas muerto");
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().getDagame(damage);
        }
    }

    protected abstract void Test();

}
