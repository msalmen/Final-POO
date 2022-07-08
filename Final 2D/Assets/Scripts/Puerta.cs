using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public int contadorDeLlaves = 3;


    private void DestruirPuerta(int descontarLlaves)
    {
        
        contadorDeLlaves -= descontarLlaves;
        if (contadorDeLlaves<= 0)
            Destroy(this.gameObject);
    }

    private void OnEnable()
    {
        ColectableItem.abrirpuerta += DestruirPuerta;
    }

    private void OnDisable()
    {
        ColectableItem.abrirpuerta -= DestruirPuerta;
    }
}
