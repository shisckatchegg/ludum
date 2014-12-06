using UnityEngine;
using System.Collections;

public class Buttonscript : MonoBehaviour {

	// Use this for initialization
	void Start () { }


	// Update is called once per frame
    void Update () {
		
	}
	
	void OnMouseDown(){
		GameObject[] listaTrampas;
		GameObject 	aux;
		Trampscript script;
		
		listaTrampas=GameObject.FindGameObjectsWithTag("Trampa");
		aux=listaTrampas[0];
		foreach(GameObject trampa in listaTrampas){
			if(trampa.transform.position.x<aux.transform.position.x){
				aux=trampa;
			}
		}
		script=aux.GetComponent("Trampscript") as Trampscript;
		script.active=true;
	}
}