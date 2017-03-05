using UnityEngine;
using System.Collections;

public class QuestionOnEnter : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Debug.Log (other.tag);
		//GUIText q1 = GameObject.FindWithTag("Question1").GetComponent<GUIText>() as GUIText;
		//audio.Play ();

		//GameObject q1 = GameObject.FindWithTag("Question1").GetComponent<TextMesh>();
		//q1.text = "test";
		//q1.SetActive(false);
		//Debug.Log(q1);
	}
	void OnTriggerExit(Collider other){
//		Debug.Log (other.tag);
//		var audio = GetComponent<AudioSource> ();
//		audio.Stop ();
	}
}
