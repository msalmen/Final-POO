using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Enemigos/da�o")]
public class ScriptableEnemy : ScriptableObject
{

    [SerializeField]private int da�o;
    public int Da�o { get {return da�o;}set { da�o = value; } }
    
}
