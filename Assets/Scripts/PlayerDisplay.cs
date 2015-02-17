
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {
	public Text scoreText;
	
	public void UpdateScoreText(int newScore){
		string scoreMessage = "Score = " + newScore;
		scoreText.text = scoreMessage;
	}
}