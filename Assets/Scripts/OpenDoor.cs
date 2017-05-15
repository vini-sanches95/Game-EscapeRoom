using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour {

	bool open, animate;
	AudioClip doorSound;
	AudioSource source;

	// Use this for initialization
	void Start () {

		open = false;
		animate = false;
		doorSound = (AudioClip) Resources.Load ("door_2");
		gameObject.AddComponent<AudioSource> ();
		source = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		open = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().key;

		if (open && animate) {
			//se o jogador pegou a chave e pressiona E para abrir a porta
			if (Input.GetKeyUp (KeyCode.E)) {
				source.PlayOneShot(doorSound);
				StartCoroutine (winMenu (1.8f));
			}
		}


	}

	void OnTriggerEnter(Collider col){
		if (col.name == "player")
			animate = true;
	}

	void OnTriggerStay(Collider col){
		if (col.name == "player")
			animate = true;
	}

	void OnTriggerExit(Collider col){
		if (col.name == "player")
			animate = false;
	}

	IEnumerator winMenu(float time){
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene (3);
	}
}
