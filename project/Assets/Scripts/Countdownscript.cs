using UnityEngine;
using System.Collections;

public class Countdownscript : MonoBehaviour {
	private float timer=300;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer=timer-Time.deltaTime;
		guiText.text = timer.ToString("0");
	}
	
	
}
