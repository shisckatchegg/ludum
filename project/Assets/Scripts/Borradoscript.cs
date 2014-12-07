using UnityEngine;
using System.Collections;

public class Borradoscript : MonoBehaviour {

	private bool hasSpawn;

	// Use this for initialization
	void Start () {
		hasSpawn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (hasSpawn == false) {//Aparecen fuera de pantalla
			if (renderer.IsVisibleFrom (Camera.main)) {
				hasSpawn = true;
			}
		}
		else {//Una vez entran en pantalla, si salen se borran a los 15 segundos
			if (renderer.IsVisibleFrom (Camera.main) == false) {
				Destroy(this.gameObject, 10);
			}
		}	
	}
}
