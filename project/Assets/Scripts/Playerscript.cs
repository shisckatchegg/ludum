using UnityEngine;
using System.Collections;

public class Playerscript : MonoBehaviour {

	public float speed = 50;
	public float jumpStrength = 10;
	private Vector2 movement;
	private bool jumping = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool jump = Input.GetButtonDown ("Jump");
		float inputX = Input.GetAxis ("Horizontal");
		float velSalto=0;
		if(jump && !jumping){
			jumping=true;
			velSalto=jumpStrength;
		}
		else{
			velSalto=0;
		}
		
		if(jumping && transform.position.y<=0){
			jumping=false;
		}
		movement = new Vector2 (speed * inputX, velSalto);

		var dist = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3(0, 0, dist)).x;
		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3(1, 0, dist)).x;
		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3(0, 0, dist)).y;
		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3(0, 1, dist)).y;

		transform.position = new Vector3 (Mathf.Clamp(transform.position.x, leftBorder, rightBorder), Mathf.Clamp(transform.position.y, topBorder, bottomBorder), transform.position.z);
	}

	void FixedUpdate () {
		rigidbody2D.velocity = movement;
	}

}
