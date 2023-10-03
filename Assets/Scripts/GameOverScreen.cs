using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public ScoreScript scoreScreen;
    public Wall wall;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActiveScreen()
    {
        wall.Barrier();
        gameObject.SetActive(true);
        //Time.timeScale = 0f;
    }
}