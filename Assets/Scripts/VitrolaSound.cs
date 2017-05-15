using UnityEngine;
using System.Collections;

public class VitrolaSound : MonoBehaviour {

	AudioClip song1, song2, song3, song4, button;
	AudioSource source;
	bool playerOnRange;
	int id;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource> ();
		source = gameObject.GetComponent<AudioSource> ();
		song1 = (AudioClip)Resources.Load ("give_you_up");
		song2 = (AudioClip)Resources.Load ("beatles");
		song3 = (AudioClip)Resources.Load ("sweet_child");
		song4 = (AudioClip)Resources.Load ("abba");
		button = (AudioClip)Resources.Load ("button");
		playerOnRange = false;
		id = 0;
		source.spatialBlend = 1;	// para que o som seja tridimensional
	}
	
	// Update is called once per frame
	void Update () {

		if (playerOnRange) {
			if (Input.GetKeyUp (KeyCode.E)) {
				id++;
				source.Stop ();
				switch (id) {
				case 1:
					source.PlayOneShot (button);
					StartCoroutine(PlayAfter(song1));
					break;
				case 2:
					source.PlayOneShot (button);
					StartCoroutine (PlayAfter (song2));
					break;
				case 3:
					source.PlayOneShot (button);
					StartCoroutine (PlayAfter (song3));
					break;
				case 4:
					source.PlayOneShot (button);
					StartCoroutine (PlayAfter (song4));
					break;
				case 5:
					source.PlayOneShot (button);
					id = 0;
					break;
				}
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "player") {
			playerOnRange = true;
		}
	}

	void OnTriggerStay(Collider col){
		if (col.name == "player") {
			playerOnRange = true;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.name == "player") {
			playerOnRange = false;
		}
	}

	IEnumerator PlayAfter(AudioClip song){
		yield return new WaitForSeconds (1.5f);
		source.PlayOneShot (song);
	}
}
