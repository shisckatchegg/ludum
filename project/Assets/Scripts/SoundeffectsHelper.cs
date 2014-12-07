using UnityEngine;
using System.Collections;

public class SoundeffectsHelper : MonoBehaviour {
	public static SoundeffectsHelper Instance;

	public AudioClip hitSound;
	public AudioClip zombieSound;
	public AudioClip zombieDeathSound;

	// Use this for initialization
	void Awake () {
		if (Instance != null)
						Debug.LogError ("Multiples instancias de SoundeffectsHelper!");
		Instance = this;
	}

	public void MakeHitSound(){
				MakeSound (hitSound);
		}

	public void MakeZombieSound(){
				MakeSound (zombieSound);
		}

	public void MakeZombieDeathSound(){
		MakeSound (zombieDeathSound);
	}

	private void MakeSound(AudioClip originalClip){
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}
