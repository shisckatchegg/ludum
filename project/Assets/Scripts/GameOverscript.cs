﻿using UnityEngine;
using System.Collections;

public class GameOverscript : MonoBehaviour {

	const int buttonWidth = 120;
	const int buttonHeight = 60;

	void Update (){
					Debug.Log("ENTRA?");
		if (Input.GetKeyDown ("escape")) {
			Debug.Log("SALE?");
			if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Retry!"
			)
			) {
				// Reload the level
				Application.LoadLevel("main");
			}

			if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Back to menu"
			)
			){
				// Reload the level
				Application.LoadLevel("Menu");
			}
				
		}
	}
	
	
	void OnGUI()
	{
		
		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Retry!"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("main");
		}
		
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Back to menu"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Menu");
		}
	}
}