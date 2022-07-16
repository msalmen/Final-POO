using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeMonedas : MonoBehaviour
{
    public Text gameOver;
    public Text contador;
    int puntos = 0;

    public void GameOverText()
    {
        gameOver.text = "GAME OVER";
    }

    public void YouWinText()
    {
        gameOver.text = "YOU WIN";
    }


    public void SumarPuntos()
    {

        puntos++;
        contador.text = "Puntos: " + puntos.ToString();
    }

    private void OnEnable()
    {
        Moneda.sumarpuntos += SumarPuntos;
        PlayerMovement.gameOver += GameOverText;
        Bandera.youWin += YouWinText;
    }

    private void OnDisable()
    {
        Moneda.sumarpuntos -= SumarPuntos;
        PlayerMovement.gameOver -= GameOverText;
        Bandera.youWin -= YouWinText;
    }
}
