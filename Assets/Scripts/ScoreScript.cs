using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public float contadorScore = 0f;
    private float highScore = 0f;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        ActualizarPuntajes();
    }

    private void Update()
    {
        contadorScore += Time.deltaTime;

        if (contadorScore > highScore)
        {
            highScore = contadorScore;
            PlayerPrefs.SetFloat("HighScore", highScore);
            PlayerPrefs.Save();
        }

        ActualizarPuntajes();
    }

    private void ActualizarPuntajes()
    {
        scoreText.text = "Puntaje: " + (contadorScore * 2).ToString("F0");
        highScoreText.text = "Puntaje más alto: " + (highScore * 2).ToString("F0");
    }

    public void ActiveScreen()
    {
        gameObject.SetActive(true);
    }

    public void DisableScreen()
    {
        gameObject.SetActive(false);
    }
}
