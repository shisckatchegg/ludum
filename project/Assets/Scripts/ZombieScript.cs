using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter2D(Collision2D objeto){
		if (objeto.gameObject.tag=="Trampa" && objeto.gameObject.GetComponent("TrampScript") as TrampScript.activate){
			//añadir espera para animación mas adelante
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
