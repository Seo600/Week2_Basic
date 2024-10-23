using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    private TextMeshProUGUI scoreText;
    private void Awake()
    {
        scoreButton.scoreButton.onClick.AddListener(() => RefreshUI(1));
        scoreButton.OnScoreChanged += RefreshUI;
    }

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void RefreshUI(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}
