using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private PlayerDisplay playerDisplay;
	
	private int score = 0;
	private float deathY = -15;
	
	void Start(){
		playerDisplay = GetComponent<PlayerDisplay>();
		playerDisplay.UpdateScoreText(score);
	}
	
	void Update(){
		float y = transform.position.y;
		if(y < deathY){
			MoveToStartPosition();
		}
	}
	
	private void MoveToStartPosition(){
		Vector3 startPosition = new Vector3(0,5,0);
		transform.position = startPosition;
	}
	
	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("Food")){
			score++;
			playerDisplay.UpdateScoreText(score);
			Destroy (hit.gameObject);
			audio.Play();
		}
	}
}
