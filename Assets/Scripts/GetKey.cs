using UnityEngine;
using System.Collections;

public class GetKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "player") {
			if (Input.GetKeyUp (KeyCode.E)) {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().key = true;
				Destroy (this.gameObject);
			}
		}
	}

	void OnTriggerStay(Collider col){
		if(col.name == "player"){
			if (Input.GetKeyUp (KeyCode.E)) {
				GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().key = true;
				Destroy (this.gameObject);
			}
		}
	}
}
