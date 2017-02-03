using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	bool moved;
	bool move;
	float distMoved, pushDist;
	public float movWanted, speed;
	GameObject player, dest;

	// Use this for initialization
	void Start () {
		moved = false;
		move = false;
		distMoved = 0;
		player = GameObject.Find ("player");
		movWanted = 2.0f;
		pushDist = 0.3f;
		speed = 2.0f;
	}

	// Update is called once per frame
	void Update () {

//		RaycastHit hit;
//		if(Physics.Raycast(player.transform.position, player.transform.forward, out hit, 2.0f)){
//			if (hit.collider.gameObject == transform.gameObject) {
//				if (Input.GetKeyUp (KeyCode.E)) {
//					if (!moved)
//						move = true;
//				}
//			}
//		}
//
//		if (move){
//			if (distMoved < movWanted) {
//				distMoved += speed * Time.deltaTime;
//				transform.Translate (speed * Time.deltaTime, 0, 0);
//			} else {
//				moved = true;
//				move = false;
//			}
//		}


		RaycastHit hit;
		if (Physics.Raycast (player.transform.position, player.transform.forward, out hit, 1f)) {
			if (hit.collider.gameObject.Equals (this.gameObject)) {
				if (Input.GetKeyUp (KeyCode.E)) {
					distMoved += pushDist;
					GetComponent<Rigidbody>().MovePosition(transform.position + new Vector3(0, 0, -pushDist));
//					transform.Translate (pushDist, 0, 0);
				}
			}
		}

	}
}
