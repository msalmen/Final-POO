using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moneda : ColectableItem
{
    public static event Action sumarpuntos;
    public override void colect()
    {
        sumarpuntos?.Invoke();
    }

}
