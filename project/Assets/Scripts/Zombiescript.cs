using UnityEngine;
using System.Collections;

public class Zombiescript : MonoBehaviour {
	private Animator animator;
	private GameObject counter;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
		counter=GameObject.Find("killCount");
	}

	/*void OnCollisionEnter2D(Collision2D objeto) {
		trampa=objeto.gameObject.GetComponent("Trampscript") as Trampscript;
		if (objeto.gameObject.tag=="Trampa" && trampa.activate){
			//añadir espera para animación mas adelante
			Destroy(this.gameObject);
		}
	}*/

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Trampscript trampa = otherCollider.gameObject.GetComponent<Trampscript> ();
		if (trampa != null) {
			Destroy(trampa.gameObject);
			Specialeffectscript.Instance.Explosion(transform.position);
			SoundeffectsHelper.Instance.MakeHitSound();
			counter.GetComponent<Killedcounterscript>().killed++;
			StartCoroutine(Die());
		}
	}
	
	// Update is called once per frame
	void Update () {	
	}
	
	private IEnumerator Die()
	{
		animator.SetBool("ifHit", true );
		SoundeffectsHelper.Instance.MakeZombieDeathSound();
		yield return new WaitForSeconds(0.2f);
		Destroy(gameObject);
	}
}
