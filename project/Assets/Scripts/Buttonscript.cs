using UnityEngine;
using System.Collections;

public class Buttonscript : MonoBehaviour {
	// Use this for initialization
	void Start () { }

	// Update is called once per frame
    void Update () {
	}

	void OnMouseDown() {
		GameObject[] listaTrampas;
		GameObject aux;
		listaTrampas = GameObject.FindGameObjectsWithTag("Trap");
		if(listaTrampas.Length != 0) {
			aux = listaTrampas[0];
			foreach(GameObject trampa in listaTrampas) {
				if(renderer.IsVisibleFrom (Camera.main) && trampa.transform.position.x<aux.transform.position.x) {
					aux = trampa;
				}
			}

			aux.GetComponent<Trampscript>().activate = true;
		}	
	}
}