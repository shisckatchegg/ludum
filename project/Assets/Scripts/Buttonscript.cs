using UnityEngine;
using System.Collections;

public class Buttonscript : MonoBehaviour {
	// Use this for initialization
	public Sprite pulsado;
    public Sprite sinPulsar;
	void Start () { }

	// Update is called once per frame
    void Update () {
		
	}

	void OnMouseDown() {
		GetComponent<SpriteRenderer>().sprite=pulsado;
		GameObject[] listaTrampas;
		GameObject aux;
		listaTrampas = GameObject.FindGameObjectsWithTag("Trap");
		if(listaTrampas.Length > 0) {
			aux = listaTrampas[0];
			foreach(GameObject trampa in listaTrampas) {
				if(trampa.renderer.IsVisibleFrom (Camera.main) && trampa.transform.position.x < aux.transform.position.x) {
					aux = trampa;
				}
			}

			aux.GetComponent<Trampscript>().activate = true;
		}	
	}
	
	void OnMouseUp() {
		GetComponent<SpriteRenderer>().sprite=sinPulsar;
	}
}