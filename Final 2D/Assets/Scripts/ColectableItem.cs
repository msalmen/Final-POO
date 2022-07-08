using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColectableItem : MonoBehaviour, Collectable
{
    public string nombre;
    public static event Action <int>abrirpuerta;


    public virtual void colect()
    {
        
        Debug.Log("me juntaron" + nombre);
        abrirpuerta?.Invoke(1);

    }    
}
