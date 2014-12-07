using UnityEngine;
using System.Collections;

public class Spawnerscript : MonoBehaviour
{
	public float spawnTime = 50f;		// The amount of time between each spawn.
	public float spawnDelay = 10f;		// The amount of time before spawning starts.
	public GameObject[] traps;		// Array of trap prefabs.


	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}


	void Spawn ()
	{
		// Instantiate a random enemy.
		int trapIndex = Random.Range(0, traps.Length);
		Instantiate(traps[trapIndex], transform.position, transform.rotation);

		/*// Play the spawning effect from all of the particle systems.
		foreach(ParticleSystem p in GetComponentsInChildren<ParticleSystem>())
		{
			p.Play();
		}*/
	}
}
