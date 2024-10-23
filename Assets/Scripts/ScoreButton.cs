using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
	public Button scoreButton;
	public int score;

	private void Awake()
	{
		scoreButton = GetComponent<Button>();
		scoreButton.onClick.AddListener(PointUp);
	}

	public void PointUp()
	{
		score += 1;
	}
}
