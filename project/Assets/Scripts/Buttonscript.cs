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
		GameObject aux;
		
		listaTrampas=GameObject.FindGameObjectsWithTag("Trap");
		if(listaTrampas!=null){
			aux=listaTrampas[0];
			foreach(GameObject trampa in listaTrampas){
				if(trampa.transform.position.x<aux.transform.position.x){
					aux=trampa;
				}
			}
			
			aux.GetComponent<Trampscript>().setActivate(true);
		}
		else{
			Debug.Log("No hay trampas");
		}
	}
}