using UnityEngine;
using System.Collections;

public class Solved : MonoBehaviour {

	bool solved, keyExists;
	float maxRotation, diffRotation, speed;

	// Use this for initialization
	void Start () {
		solved = false;
		maxRotation = 90;
		diffRotation = 0;
		speed = 20;
		keyExists = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		solved = GameObject.Find("QuadroVazio").GetComponent<PaintingFrame> ().solved;

		if (solved) {
			if (diffRotation < maxRotation) {
				diffRotation += speed * Time.deltaTime;
				transform.Rotate (0, speed * Time.deltaTime, 0);
			}
			if (diffRotation < 18 && diffRotation > 16 && !keyExists) {
				//Component[] meshes;
				GameObject key = (GameObject)Instantiate (Resources.Load ("key"));
				key.transform.localScale = new Vector3(0.003f, 0.003f, 0.003f);
				key.transform.Rotate (-270, 0, 0);
				key.transform.position = new Vector3 (3.5f, 2.361f, 8.8054f);
				//key.GetComponent<MeshCollider> ().convex = true;
//				meshes = key.GetComponentsInChildren<MeshCollider> ();
//				foreach (Component c in meshes)
//					c.GetComponent<MeshCollider> ().convex = true;
//				key.AddComponent<Rigidbody> ();
//				key.GetComponent<Rigidbody> ().useGravity = true;
//				key.GetComponent<Rigidbody> ().isKinematic = true;
				key.AddComponent<GetKey>();
				key.AddComponent<BoxCollider> ();
				key.GetComponent<BoxCollider> ().center = new Vector3 (110, -114, 100);
				key.GetComponent<BoxCollider> ().size = new Vector3 (440, 239, 460);
				key.GetComponent<BoxCollider> ().isTrigger = true;
				keyExists = true;
			}
		}

	}
}
