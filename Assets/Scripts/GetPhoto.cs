using UnityEngine;
using System.Collections;

public class GetPhoto : MonoBehaviour {

	GameObject player;
	string name;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player");
		name = this.gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (Input.GetKeyUp (KeyCode.E)) {
			if (col.name == "player" && name == "photo1") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece1 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo2") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece2 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo3") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece3 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo4") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece4 = true;
				Destroy (this.gameObject);
			}
		}
	}

	void OnTriggerStay(Collider col){
		if (Input.GetKeyUp (KeyCode.E)) {
			if (col.name == "player" && name == "photo1") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece1 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo2") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece2 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo3") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece3 = true;
				Destroy (this.gameObject);
			}
			if (col.name == "player" && name == "photo4") {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece4 = true;
				Destroy (this.gameObject);
			}
		}
	}
}
