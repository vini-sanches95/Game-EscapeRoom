using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	Button but;

	// Use this for initialization
	void Start () {
		but = GetComponent<Button> ();
		but.onClick.AddListener (StartGame);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartGame(){
		SceneManager.LoadScene (1);
	}
}
