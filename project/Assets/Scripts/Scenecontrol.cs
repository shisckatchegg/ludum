using UnityEngine;
using System.Collections;

public class Scenecontrol : MonoBehaviour {
	GameObject timer;
	private bool added = false;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find("Timer");
	}

	// Update is called once per frame
	void Update () {

		if(timer.GetComponent<Countdownscript>().timer <= 0 && !added) {
			//Application.LoadLevel("Menu");
			//if(transform.parent.gameObject.GameOverscript){
			gameObject.AddComponent<GameOverscript>();
			added = true;			//}	

		}
	}
}
