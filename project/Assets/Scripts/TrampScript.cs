using UnityEngine;
using System.Collections;

public class TrampScript : MonoBehaviour {

	public bool activate;

	public Vector2 speed = new Vector2 (10, 10);
	private Vector2 direction = new Vector2 (0, -1);
	private Vector2 movement;

	// Use this for initialization
	void Start () {}
	

	// Update is called once per frame
	void Update () {
		
		if(activate) {
			movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
		}
	}
		
	void FixedUpdate() {
		rigidbody2D.velocity = movement;
	}
}
