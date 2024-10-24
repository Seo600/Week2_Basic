using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
	public Button scoreButton;
	public int score;
	public Action<int> OnScoreChanged;

	private void Awake()
	{
		scoreButton = GetComponent<Button>();
		scoreButton.onClick.AddListener(PointUp);
	}

	public void PointUp()
	{
		score += 1;
		OnScoreChanged?.Invoke(score);
	}
}
