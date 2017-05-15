using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour {

	Button but;
	int index;
	GameObject m, mt, a, at, e, et, o, esc, esct;

	// Use this for initialization
	void Start () {
		index = 0;
		but = GetComponent<Button> ();
		but.onClick.AddListener (next);
		m = GameObject.Find ("mouse");
		mt = GameObject.Find ("mouseTxt");
		a = GameObject.Find ("arrows");
		at = GameObject.Find ("arrowsTxt");
		e = GameObject.Find ("eKey");
		et = GameObject.Find ("eKeyTxt");
		o = GameObject.Find ("objective");
		esc = GameObject.Find ("ESC");
		esct = GameObject.Find ("ESCtxt");
		o.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void next(){
		if (index % 2 == 0) {
			m.SetActive (false);
			mt.SetActive (false);
			a.SetActive (false);
			at.SetActive (false);
			e.SetActive (false);
			et.SetActive (false);
			esc.SetActive (false);
			esct.SetActive (false);
			o.SetActive (true);
		} else {
			m.SetActive (true);
			mt.SetActive (true);
			a.SetActive (true);
			at.SetActive (true);
			e.SetActive (true);
			et.SetActive (true);
			esc.SetActive (true);
			esct.SetActive (true);
			o.SetActive (false);
		}
		index++;
	}
}
