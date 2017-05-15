using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	float distMoved, pushDist;
	public float movWanted, speed;
	GameObject player, dest;
	float max;		// the max it can be moved
	GameObject thisOne;

	// Use this for initialization
	void Start () {
		distMoved = 0;
		player = GameObject.Find ("player");
		movWanted = 2.0f;
		pushDist = 0.3f;
		speed = 2.0f;
		thisOne = this.gameObject;
		if (thisOne.name == "adega1")
			max = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().maxMoveAdega1;
	}

	// Update is called once per frame
	void Update () {

		if (thisOne.name == "adega2")
			// o maximo que pode mover esta adega é até encostar na outra
			max = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().maxMoveAdega2;

		RaycastHit hit;
		if (Physics.Raycast (player.transform.position, player.transform.forward, out hit, 1f)) {
			if (hit.collider.gameObject.Equals (this.gameObject)) {
				if (Input.GetKeyUp (KeyCode.E)) {
					// se o jogador esta em range e pressiona E, move um pouco a adega
					if (thisOne.name == "adega1" && distMoved <= pushDist*10) {
						distMoved += pushDist;
						transform.Translate (pushDist, 0, 0);
						GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().maxMoveAdega2 = distMoved;
					} else {
						if (distMoved < max) {
							distMoved += pushDist;
							transform.Translate(pushDist, 0, 0);
						}
					}
				}
			}
		}

	}
}
