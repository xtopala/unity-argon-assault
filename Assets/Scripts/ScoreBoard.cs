﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int score = 0;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    public void ScoreHit(int scorePerHit)
    {
        score += scorePerHit;
    }
}
