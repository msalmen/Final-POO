using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeMonedas : MonoBehaviour
{
    public Text contador;
    int puntos;

    public void SumarPuntos()
    {
        puntos++;
        contador.text = puntos.ToString();
    }

    private void OnEnable()
    {
        Moneda.sumarpuntos += SumarPuntos;
    }

    private void OnDisable()
    {
        Moneda.sumarpuntos -= SumarPuntos;
    }
}
