using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

	public Text scoreText;
	public Text hiScoreText;

	ScoreManager scoreMan;

	void Awake() {
		scoreMan = ScoreManager.GetInstance ();
		UpdateScore (0);
		UpdateHiScore (0);
	}

	void OnEnable() {
		scoreMan.OnScore += UpdateScore;
		scoreMan.OnHiScore += UpdateHiScore;
	}
	void OnDisable() {
		scoreMan.OnScore -= UpdateScore;
		scoreMan.OnHiScore -= UpdateHiScore;
	}

	private void UpdateScore(int scoreDiff) {
		scoreText.text = "" + scoreMan.GetScore ();
	}

	private void UpdateHiScore(int scoreDiff) {
		hiScoreText.text = "" + scoreMan.GetHiScore ();
	}



}
