using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    private TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.OnScoreChanged += RefreshUI;
    }

    // Update is called once per frame
    public void RefreshUI(int score)
    {
        scoreText.text = score.ToString();
    }
}
