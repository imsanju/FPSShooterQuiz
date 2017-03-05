using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public Canvas exit;
	public Button startText;
	public Button exitText;
	public Button instructionText;
	public Canvas instructionCanvas;


	// Use this for initialization
	void Start () {
		exit = exit.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		//instructionText = instructionText.GetComponent<Button> ();
		GameObject tempCanvas = GameObject.Find ("InstructionCanvas");
		instructionCanvas = tempCanvas.GetComponent<Canvas> ();
		Debug.Log ("found instruciton Canvas");
		instructionCanvas.enabled = false;
		exit.enabled = false;

	}
	
	public void onExit ()
	{
		exit.enabled = true;
		instructionCanvas.enabled = false;
		startText.enabled = false;
		exitText.enabled = false;

	}

	public void notPressed ()
	{
		exit.enabled = false;
		instructionCanvas.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;

	}

	public void startGame ()
	{
		SceneManager.LoadScene ("rockyTerrain");

	}

	public void exitGame ()
	{
		Application.Quit ();
	}


	public void instructions()
	{
		Debug.Log ("reached instructions button function");
		instructionCanvas.enabled = true;
	}

	public void closeInstructions()
	{
		instructionCanvas.enabled = false;
	}
}
