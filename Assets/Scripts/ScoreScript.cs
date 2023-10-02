using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public float contadorScore = 0f;

    private void Update()
    {
        contadorScore += Time.deltaTime;
        scoreText.text = (contadorScore * 2).ToString("Puntaje: 0");
    }
}
