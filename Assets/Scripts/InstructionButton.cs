using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionButton : MonoBehaviour {

	Button but;

	// Use this for initialization
	void Start () {
		but = GetComponent<Button> ();
		but.onClick.AddListener (Instructions);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Instructions(){
		SceneManager.LoadScene (2);
	}
}
