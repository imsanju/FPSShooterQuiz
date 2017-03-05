using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuestionManager : MonoBehaviour {

	public Questions[] questions;
	private static List<Questions> unansweredQuestions; 
	private Questions currentQuestion;
	public GameObject qqq;

	[SerializeField]
	private Text factText;

	[SerializeField]
	private float timeBetweenQuestions = 1f;
		
	// Use this for initialization
	void Start () {
		if (unansweredQuestions == null) {
		
			unansweredQuestions = questions.ToList<Questions> ();
		}

		GetRandomQuestion();
	}



	 IEnumerator TransitionToNextQuestion () {
		unansweredQuestions.Remove (currentQuestion);
		yield return new WaitForSeconds (timeBetweenQuestions);
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);

	}

	public void startRoutine(){
		StartCoroutine (TransitionToNextQuestion ());
	}

	public string GetRandomQuestion() {
	
		int randomQIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions [randomQIndex];
		string questionToBe = currentQuestion.fact != null ? currentQuestion.fact : "Hi Sanju";

		if (factText != null) {
			factText.text = questionToBe;
		}

	
		unansweredQuestions.RemoveAt (randomQIndex);


		var w = GameObject.FindWithTag ("qText");
	
		factText =  w.gameObject.GetComponent<Text>();

		Debug.Log (factText.text);

		return questionToBe;

	}

}
