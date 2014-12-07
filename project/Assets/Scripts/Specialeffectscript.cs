using UnityEngine;
using System.Collections;

public class Specialeffectscript : MonoBehaviour{
	
	public static Specialeffectscript Instance;

	public ParticleSystem BloodSplatter;

	void Awake() {
		if (Instance != null)
			Debug.LogError ("Instanciado multiple de SpecialEffect");

		Instance = this;
	}



	public void Explosion(Vector3 position) {
		Instantiate (BloodSplatter, position);
	}



	private ParticleSystem Instantiate(ParticleSystem prefab, Vector3 position) {
		ParticleSystem newParticleSystem = Instantiate (prefab, position, Quaternion.identity)as ParticleSystem;

		Destroy (newParticleSystem.gameObject, newParticleSystem.startLifetime);

		return newParticleSystem;
	}
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
