﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(.1f,10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int PointPerBlock = 83;

    [SerializeField] int currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
    public void AddToScore()
    {
        currentScore = currentScore + PointPerBlock;
    }
}
