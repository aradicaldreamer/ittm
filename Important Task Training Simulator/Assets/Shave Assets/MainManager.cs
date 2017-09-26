using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {

	// Amount of circles
	[SerializeField] Transform cremeFolder;

	// Check win condition
	int amountToShave;
	public static int amountShaved;

	[SerializeField] Text winPercentageUI;

	void Awake()
	{
		amountToShave = cremeFolder.childCount;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CalculateWinPercentage();
		CheckWinState();
	}
		

	void CheckWinState()
	{
		if (amountShaved >= amountToShave)
		{
			print("Win");
		}
			
	}

	void CalculateWinPercentage()
	{
		int winPercentage = (int) ((float) amountShaved / amountToShave * 100);
		print(winPercentage);
		winPercentageUI.text = winPercentage.ToString() + '%';
	}
}
