using UnityEngine;
using System.Collections;

public class Scenecontrol : MonoBehaviour {
	GameObject timer;
	GameObject killCount;
	private bool added = false;
	public int winCondition = 10;
	private GameObject[] zombies;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find("Timer");
		killCount = GameObject.Find("killCount");
		guiText.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit();
		
		
		zombies = GameObject.FindGameObjectsWithTag("Zombie");
		foreach(GameObject zombie in zombies)
		{
			if(zombie.transform.position.x > 0 && zombie.renderer.IsVisibleFrom (Camera.main) == false && !added)
			{
				guiText.enabled = true;
				guiText.text = "You failed defending the laboratory!";
				gameObject.AddComponent<GameOverscript>();
				added = true;
			}
		}
		
		if(timer.GetComponent<Countdownscript>().timer <= 0 && !added) {
			guiText.enabled = true;
			guiText.text = "You failed defending the laboratory!";
			gameObject.AddComponent<GameOverscript>();
			added = true;
		}

		if(killCount.GetComponent<Killedcounterscript>().killed >= winCondition && !added) {
			guiText.enabled = true;
			guiText.text = "Laboratory defended succesfully!";
			gameObject.AddComponent<GameOverscript>();
			added = true;

		}
	}
}
