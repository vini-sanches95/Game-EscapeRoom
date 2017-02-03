using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	Transform naMao;
	float distance;
	bool picked;	// se TRUE, ele foi pego
	Vector3 originalPos;

	// Use this for initialization
	void Start () {
		naMao = GameObject.Find ("naMao").transform;
		distance = 2.0f;
		picked = false;
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (picked && Vector3.Distance (GameObject.Find ("player").transform.position, transform.position) <= distance) {
			GetComponent<Rigidbody> ().useGravity = false;
			GetComponent<Rigidbody> ().freezeRotation = true;
			GetComponent<Rigidbody>().MovePosition(naMao.transform.position);
			//this.transform.position = naMao.position;
			this.transform.parent = GameObject.Find ("player").transform;
			this.transform.parent = GameObject.Find ("FirstPersonCharacter").transform;
		} else {
			this.transform.parent = null;
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().freezeRotation = false;
		}
		if (transform.position.y < -3) {
			this.transform.position = naMao.position;
		}

	}

	void OnMouseDown(){
		picked = true;
	}

	void OnMouseUp(){
		picked = false;
	}

}
