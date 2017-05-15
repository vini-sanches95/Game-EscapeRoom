using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	Button but;

	// Use this for initialization
	void Start () {
		but = GetComponent<Button> ();
		but.onClick.AddListener (Back);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Back(){
		SceneManager.LoadScene (0);
	}

}
