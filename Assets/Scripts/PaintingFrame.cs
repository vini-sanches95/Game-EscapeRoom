using UnityEngine;
using System.Collections;

public class PaintingFrame : MonoBehaviour {

	bool playerOnRadius;
	bool has1, has2, has3, has4;
	Texture tex1, tex2, tex3, tex4;
	public bool solved;

	// Use this for initialization
	void Start () {
		has1 = false;
		has2 = false;
		has3 = false;
		has4 = false;
		playerOnRadius = false;
		tex1 = (Texture) Resources.Load ("PicPArt1");
		tex2 = (Texture) Resources.Load ("PicPart2");
		tex3 = (Texture) Resources.Load ("PicPart3");
		tex4 = (Texture) Resources.Load ("PicPart4");
		solved = false;

	}
	
	// Update is called once per frame
	void Update () {

		has1 = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece1;
		has2 = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece2;
		has3 = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece3;
		has4 = GameObject.Find ("Global Handler").GetComponent<GlobalHandler> ().photoPiece4;

		if (playerOnRadius) {
			if (Input.GetKeyUp (KeyCode.E)) {
				if (has1)
					GameObject.Find("picPart1").GetComponent<Renderer> ().material.mainTexture = tex1;
				if(has2)
					GameObject.Find("picPart2").GetComponent<Renderer> ().material.mainTexture = tex2;
				if(has3)
					GameObject.Find("picPart3").GetComponent<Renderer> ().material.mainTexture = tex3;
				if(has4)
					GameObject.Find("picPart4").GetComponent<Renderer> ().material.mainTexture = tex4;
				if (has1 && has2 && has3 && has4)	// the player solved the picture puzzle
					solved = true;
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.name == "player") {
			playerOnRadius = true;
		}
	}


	// talvez nao seja necessario
	void OnTriggerStay(Collider col){
		if (col.name == "player") {
			playerOnRadius = true;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.name == "player")
			playerOnRadius = false;
	}

}
