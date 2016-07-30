using UnityEngine;
using System.Collections;

public class wallBoundary : MonoBehaviour {

	public AudioClip wallCollision;

	void OnCollisionEnter(Collision other) {


		AudioSource audio = GetComponent<AudioSource> ();
		audio.PlayOneShot(wallCollision);
	}	
}
