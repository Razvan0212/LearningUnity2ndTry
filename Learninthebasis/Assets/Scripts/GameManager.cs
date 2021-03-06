﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay = 1f;
    public GameObject LevelCompleteUI;
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }

    public bool GetState() { return gameHasEnded; }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    internal void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }
}
