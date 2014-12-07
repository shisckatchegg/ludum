using UnityEngine;
using System.Collections;

public class Zombiespawn : MonoBehaviour {
	public int numZombies=30;
	public GameObject spawn;
	// Use this for initialization
	void Start () {
		for(int i=0;i<numZombies;i++){
			spawnZombie();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void spawnZombie(){
		Vector3 position = new Vector3(Random.Range(-10.0F, -5.0F), 0, 0);
		Instantiate(spawn,position,Quaternion.identity);
	}
}
