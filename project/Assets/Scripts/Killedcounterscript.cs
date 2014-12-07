using UnityEngine;
using System.Collections;

public class Killedcounterscript : MonoBehaviour {
	public int killed;

	// Use this for initialization
	void Start () {
		killed=0;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = killed.ToString("0");
	}
}
