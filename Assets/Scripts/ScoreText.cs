using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        scoreButton.scoreButton.onClick.AddListener(RefreshUI);
    }

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void RefreshUI()
    {
        scoreText.text = scoreButton.score.ToString();
    }
}
