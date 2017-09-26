using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public float timeLeft;
	public float RunTime;
	public Text InstructionText;
	public Text TimerText;

	// Use this for initialization
	void Start () {
		RunTime = 10.0f;
		timeLeft = 10.0f;
		SetTimerText ();
		InstructionText.text = "";
	}

	// Update is called once per frame
	void Update () {
		if (timeLeft > 0.0f) {
			timeLeft = RunTime - Time.time;
		} else if (timeLeft < 0.0f) {
			timeLeft = 0;
		}
		SetInstructionText ();
		SetTimerText ();
	}

	public void SetInstructionText (){
		InstructionText.text = "Peel the banana!";
	}

	public void SetTimerText ()
	{
		TimerText.text = "Time Left: " + timeLeft.ToString () + " seconds";
		//  if (timeLeft <= 0.0f && score < 10) {
		//	WinText.text = "You Lose!";
		// }
	}
}
