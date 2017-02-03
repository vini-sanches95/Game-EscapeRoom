using UnityEngine;
using System.Collections;

public class Creator : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
//		cube.transform.position = new Vector3 (0.65f, 4.2f, 0);
//		GameObject loadedHouse = (GameObject)Instantiate (Resources.Load("vitrola"));
//		loadedHouse.transform.position = new Vector3 (0.1f, 0.1f, 0.1f);
		GameObject testParent = new GameObject();
		testParent.transform.position = new Vector3 (-6.94f, 0f, -7.85f);
		GameObject test = (GameObject)Instantiate (Resources.Load ("Barrel"));
		test.GetComponentInChildren<MeshCollider> ().convex = true;
		test.transform.position = new Vector3 (-7.31f, 0f, -8.2f);
		test.transform.parent = testParent.transform;
		testParent.AddComponent<Rigidbody> ();
		//test.GetComponent<Rigidbody> ().isKinematic = true;
		testParent.AddComponent<PickUp>();
		testParent.GetComponent<Rigidbody> ().freezeRotation = true;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
