using UnityEngine;
using System.Collections;

public class GenButton : MonoBehaviour {

	bool pressed, rangeOK;
	GameObject but, rwh;
	bool showPic;
	Component[] children;
	AudioClip genaudio, explosionaudio, ignition;
	AudioSource explosionsource, gensource;

	// Use this for initialization
	void Start () {
		pressed = false;
		rangeOK = false;
		but = GameObject.Find ("Point Light Green");
		but.SetActive (false);
		showPic = false;
		rwh = GameObject.Find ("RWH");
		children = rwh.GetComponentsInChildren<MeshCollider>();

		gameObject.AddComponent<AudioSource> ();
		GameObject.Find ("RWH").AddComponent<AudioSource> ();
		gensource = gameObject.GetComponent<AudioSource> ();
		gensource.spatialBlend = 1;
		genaudio = (AudioClip)Resources.Load ("enginerun");
		explosionsource = GameObject.Find ("RWH").GetComponent<AudioSource> ();
		explosionsource.spatialBlend = 1;
		explosionaudio = (AudioClip)Resources.Load ("explosion");
		ignition = (AudioClip)Resources.Load ("ignition");
	}
	
	// Update is called once per frame
	void Update () {

		if (rangeOK && !pressed) {
			if (Input.GetKeyUp (KeyCode.E)) {
				but.SetActive (true);
				GameObject.Find ("Point Light Red").SetActive (false);
//				GameObject.Find("Button")

				gensource.PlayOneShot (ignition);
				StartCoroutine (PlayAfter (genaudio, 2.3f, gensource, false));

				pressed = true;
				showPic = true;
			}
		}

		if (showPic) {
			rwh.GetComponent<MeshCollider> ().convex = true;
			foreach (Component c in children) {
				c.gameObject.GetComponent<MeshCollider> ().convex = true;
			}

			StartCoroutine (PlayAfter (explosionaudio, 11.7f, explosionsource, true));
			showPic = false;
		}

	}

	void OnTriggerEnter(Collider col){
		if(col.name == "player")
			rangeOK = true;
	}

	void OnTriggerStay(Collider col){
		if(col.name == "player")
			rangeOK = true;
	}

	void OnTriggerExit(Collider col){
		if(col.name == "player")
			rangeOK = false;
	}

	IEnumerator PlayAfter(AudioClip song, float time, AudioSource s, bool explode){
		yield return new WaitForSeconds (time);
		s.PlayOneShot (song);
		if (explode) {
			rwh.AddComponent<Rigidbody> ();
			rwh.GetComponent<Rigidbody> ().useGravity = true;
			rwh.GetComponent<Rigidbody> ().mass = 2000;
		}
	}

}
