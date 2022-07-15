using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Enemigos/daño")]
public class ScriptableEnemy : ScriptableObject
{

    [SerializeField]private int daño;
    public int Daño { get {return daño;}set { daño = value; } }
    
}
