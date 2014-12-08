using UnityEngine;
using System.Collections;

public class Countdownscript : MonoBehaviour {
	public float timer = 300;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		timer = timer-Time.deltaTime;
		if(timer < 0)
		{
			guiText.text = "0";
		}
		else {
			guiText.text = timer.ToString("0");
		}
	}
	
	
}
