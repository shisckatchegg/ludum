using UnityEngine;
using System.Collections;

public class Zombiescript : MonoBehaviour {
	
	private bool hasSpawn;
	// Use this for initialization
	void Start () {
		hasSpawn = false;
	}

	/*void OnCollisionEnter2D(Collision2D objeto) {
		trampa=objeto.gameObject.GetComponent("Trampscript") as Trampscript;
		if (objeto.gameObject.tag=="Trampa" && trampa.activate){
			//añadir espera para animación mas adelante
			Destroy(this.gameObject);
		}
	}*/
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Trampscript trampa = otherCollider.gameObject.GetComponent<Trampscript> ();
		if (trampa != null) {
			Destroy(trampa.gameObject);
			Destroy (this.gameObject);
		}
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
				Destroy(this.gameObject, 15);
			}
		}	
	}
}
