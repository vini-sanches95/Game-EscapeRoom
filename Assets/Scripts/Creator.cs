using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Creator : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//criar sala
		this.gameObject.GetComponent<CreationMethods>().CreateRoom();
		// criar luz
		this.gameObject.GetComponent<CreationMethods>().CreateLights();
		// criar lâmpadas
		this.gameObject.GetComponent<CreationMethods> ().CreateLightBulbs ();
		//criar as fotos
		this.gameObject.GetComponent<CreationMethods>().CreatePhotos();
		//criar barris
		this.gameObject.GetComponent<CreationMethods>().CreateBarrels();
		//criar adegas
		this.gameObject.GetComponent<CreationMethods>().CreateWineHouses();
		//criar quadros
		this.gameObject.GetComponent<CreationMethods>().CreatePaintings();
		//criar puzzle do gerador
		this.gameObject.GetComponent<CreationMethods>().CreateGeneratorPuzzle();
		//criar porta e vitrola
		this.gameObject.GetComponent<CreationMethods>().CreateInteractiveObjects();
		//criar restante dos objetos na sala
		this.gameObject.GetComponent<CreationMethods>().CreateStaticObjects();
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape))
			SceneManager.LoadScene(0);
			
	}
}
