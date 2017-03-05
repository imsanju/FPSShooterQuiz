using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class audioOnEnter : MonoBehaviour {

	public static string question1;
	Text text1;

	void OnTriggerEnter(Collider other){
		//Debug.Log (other.tag);
		var audio = GetComponent<AudioSource> ();

		audio.Play ();
//		text1 = GetComponent<Text> ();
//		question1 = "What is 2 * 2? ";
//		Debug.Log (text1);
//		text1.text = question1;

		//Debug.Log (text1.text);

	}
	void OnTriggerExit(Collider other){
		//Debug.Log (other.tag);
		var audio = GetComponent<AudioSource> ();
		audio.Stop ();
	}
}
