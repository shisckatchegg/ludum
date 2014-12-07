using UnityEngine;
using System.Collections;

public class Scenecontrol : MonoBehaviour {
	GameObject timer;
	// Use this for initialization
	void Start () {
		timer=GameObject.Find("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.GetComponent<Countdownscript>().timer<=0){
			Application.LoadLevel("Menu");
		}
	}
}
