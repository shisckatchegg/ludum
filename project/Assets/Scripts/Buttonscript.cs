using UnityEngine;
using System.Collections;

public class Buttonscript : MonoBehaviour {

	// Use this for initialization
	void Start () { }


	// Update is called once per frame
    void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("Pressed left click, casting ray.");
			CastRay(gameObject);
		}
	}



	bool CastRay(GameObject objeto) {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
		if (hit.collider.gameObject==objeto){
			Debug.Log("Click en boton");
			return true;
        }
		else 
			Debug.Log("No Click en boton");
			return false;
    }    
}