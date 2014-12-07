using UnityEngine;
using System.Collections;

public class Trampscript : MonoBehaviour {
	public bool activate;
	private bool hasSpawn;

	public Vector2 speed = new Vector2 (10, 10);
	private Vector2 direction = new Vector2 (0, -1);
	private Vector2 movement;

	// Use this for initialization
	void Start () {
		hasSpawn = false;
	}

	// Update is called once per frame
	void Update () {
		if (hasSpawn == false) {
			if (renderer.IsVisibleFrom (Camera.main)) {
				hasSpawn = true;
			}
		}
		else {
			if (renderer.IsVisibleFrom (Camera.main) == false) {
				Destroy(this.gameObject);
			}
		}		
		if(activate) {
			movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
		}
	}
		
	void FixedUpdate() {
		rigidbody2D.velocity = movement;
	}
	
	public void setActivate(bool value){
		activate=value;
	}
}
