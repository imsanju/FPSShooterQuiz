using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {
	public  GameObject explosion;
	public int scoreValue = 10;
	public QuestionManager que;
	public Text ans;
	//public Transform respawnPosition;

	void OnTriggerEnter(Collider other){
	Destroy(gameObject);
		if (ScoreManager.score == null) {
			ScoreManager.score = 0;
		}
	//Debug.Log (gameObject);
	if (gameObject.CompareTag ("True") || gameObject.CompareTag ("False")) {
			if (gameObject.CompareTag ("True")) {
				Debug.Log ("score manager score" + ScoreManager.score);
				ScoreManager.score = ScoreManager.score + scoreValue;
				Debug.Log ("score value" + scoreValue);
				Debug.Log ("Score manager + score value" + ScoreManager.score);
				var answerField = GameObject.FindWithTag ("aText");
				ans = answerField.gameObject.GetComponent<Text> ();
				ans.text = "Correct Answer, +20 points! ";

			} else {
				var answerField = GameObject.FindWithTag ("aText");
				ans = answerField.gameObject.GetComponent<Text> ();
				ans.text = "Wrong Answer, Please try again :)";
			}

			que = FindObjectOfType(typeof(QuestionManager)) as QuestionManager; 
			que.GetRandomQuestion ();


	}
			
	Destroy (other.gameObject);
    Instantiate (explosion, transform.position, transform.rotation);
	

	}
}
