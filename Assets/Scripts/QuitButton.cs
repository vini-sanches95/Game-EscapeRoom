using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class QuitButton : MonoBehaviour {

	Button b;

	// Use this for initialization
	void Start () {
		b = GetComponent<Button> ();
		b.onClick.AddListener (Quit);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Quit(){
		Application.Quit ();
	}
		
}
