using UnityEngine;
using System.Collections;

public class CreationMethods : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateLightBulbs(){
		GameObject l1, l2, l3, l4;
		l1 = (GameObject)Instantiate (Resources.Load ("lampada"));
		l2 = (GameObject)Instantiate (Resources.Load ("lampada"));
		l3 = (GameObject)Instantiate (Resources.Load ("lampada"));
		l4 = (GameObject)Instantiate (Resources.Load ("lampada"));

		l1.transform.localScale = new Vector3 (0.09051008f, 0.09051008f, 0.09051008f);
		l1.transform.position = new Vector3 (4, 3.36f, -4.21f);

		l2.transform.localScale = new Vector3 (0.09051008f, 0.09051008f, 0.09051008f);
		l2.transform.position = new Vector3 (3.93f, 3.36f, 5.25f);

		l3.transform.localScale = new Vector3 (0.09051008f, 0.09051008f, 0.09051008f);
		l3
			.transform.position = new Vector3 (-5.78f, 3.36f, 5.33f);
		l4.transform.localScale = new Vector3 (0.09051008f, 0.09051008f, 0.09051008f);
		l4.transform.position = new Vector3 (-5.8f, 3.36f, -4.26f);
	}

	public void CreateLights(){
		GameObject luzTest = new GameObject();
		luzTest.name = "light1";
		luzTest.transform.position = new Vector3(4.53f, 3.32f, -4.62f);
		luzTest.AddComponent<Light>();
		luzTest.GetComponent<Light>().type = LightType.Point;
		luzTest.GetComponent<Light> ().range = 10f;
		luzTest.GetComponent<Light> ().intensity = 5.5f;

		GameObject l2 = new GameObject();
		l2.name = "light2";
		l2.transform.position = new Vector3(4.53f, 3.32f, 4.88f);
		l2.AddComponent<Light>();
		l2.GetComponent<Light>().type = LightType.Point;
		l2.GetComponent<Light> ().range = 10f;
		l2.GetComponent<Light> ().intensity = 5.5f;

		GameObject l3 = new GameObject();
		l3.name = "light3";
		l3.transform.position = new Vector3(-5.16f, 3.32f, 4.88f);
		l3.AddComponent<Light>();
		l3.GetComponent<Light>().type = LightType.Point;
		l3.GetComponent<Light> ().range = 10f;
		l3.GetComponent<Light> ().intensity = 5.5f;

		GameObject l4 = new GameObject();
		l4.name = "light4";
		l4.transform.position = new Vector3(-5.16f, 3.32f, -4.62f);
		l4.AddComponent<Light>();
		l4.GetComponent<Light>().type = LightType.Point;
		l4.GetComponent<Light> ().range = 10f;
		l4.GetComponent<Light> ().intensity = 5.5f;
	}

	public void CreateRoom(){
		GameObject floor, ceiling, wall1, wall2, wall3, wall4, viga1, viga2, viga3, viga4;
		Texture fl, ce, wa, vi;

		fl = (Texture)Resources.Load ("chao");
		ce = (Texture)Resources.Load ("teto2");
		wa = (Texture)Resources.Load ("ParedeTijolos3");
		vi = (Texture)Resources.Load ("viga");

		//chão
		floor = GameObject.CreatePrimitive (PrimitiveType.Plane);
		floor.transform.localScale = new Vector3 (2, 2, 2);
		floor.GetComponent<Renderer> ().material.mainTexture = fl;
		floor.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2 (3, 3));

		//teto
		ceiling = GameObject.CreatePrimitive (PrimitiveType.Cube);
		ceiling.transform.localScale = new Vector3 (1, 20.0264f, 20.20404f);
		ceiling.transform.position = new Vector3 (-0.47f, 4.19f, -0.17f);
		ceiling.transform.Rotate (0, 0, 90);
		ceiling.GetComponent<Renderer> ().material.mainTexture = ce;
		ceiling.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(5.29f, 1.97f));

		//paredes
		wall1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		wall2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		wall3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		wall4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		wall1.transform.localScale = new Vector3 (1, 11.76129f, 20.20404f);
		wall1.transform.position = new Vector3 (9.68f, -1.2f, -0.17f);
		wall1.GetComponent<Renderer> ().material.mainTexture = wa;
		wall1.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(7.49f, 5.36f));
		wall2.transform.localScale = new Vector3 (1, 11.76129f, 20.20404f);
		wall2.transform.position = new Vector3 (-10.37f, -1.2f, -0.17f);
		wall2.GetComponent<Renderer> ().material.mainTexture = wa;
		wall2.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(7.49f, 5.36f));
		wall3.transform.localScale = new Vector3 (1, 11.76129f, 20.20404f);
		wall3.transform.Rotate (0, 90, 0);
		wall3.transform.position = new Vector3 (-0.4173279f, 0.3f, -10.1f);
		wall3.GetComponent<Renderer> ().material.mainTexture = wa;
		wall3.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(7.49f, 5.36f));
		wall4.transform.localScale = new Vector3 (1, 11.76129f, 20.20404f);
		wall4.transform.Rotate (0, 90, 0);
		wall4.transform.position = new Vector3 (-0.4300003f, -1.2f, 9.67f);
		wall4.GetComponent<Renderer> ().material.mainTexture = wa;
		wall4.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(7.49f, 5.36f));

		//vigas
		viga1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		viga2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		viga3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		viga4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		viga1.transform.localScale = new Vector3 (0.3590278f, 0.4667883f, 22.07148f);
		viga1.transform.position = new Vector3 (7.467324f, 3.72f, 1.15f);
		viga1.GetComponent<Renderer> ().material.mainTexture = vi;
		viga1.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(0.89f, 13.28f));
		viga2.transform.localScale = new Vector3 (0.3590278f, 0.4667883f, 22.07148f);
		viga2.transform.position = new Vector3 (2.594039f, 3.72f, 1.15f);
		viga2.GetComponent<Renderer> ().material.mainTexture = vi;
		viga2.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(0.89f, 13.28f));
		viga3.transform.localScale = new Vector3 (0.3590278f, 0.4667883f, 22.07148f);
		viga3.transform.position = new Vector3 (-4.315068f, 3.72f, 1.15f);
		viga3.GetComponent<Renderer> ().material.mainTexture = vi;
		viga3.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(0.89f, 13.28f));
		viga4.transform.localScale = new Vector3 (0.3590278f, 0.4667883f, 22.07148f);
		viga4.transform.position = new Vector3 (-9.252675f, 3.72f, 1.15f);
		viga4.GetComponent<Renderer> ().material.mainTexture = vi;
		viga4.GetComponent<Renderer> ().material.SetTextureScale ("_MainTex", new Vector2(0.89f, 13.28f));
	}

	public void CreatePhotos(){
		Texture p1, p2, p3, p4;
		GameObject pic1, pic2, pic3, pic4;
		p1 = (Texture)Resources.Load ("PicPart1");
		p2 = (Texture)Resources.Load ("PicPart2");
		p3 = (Texture)Resources.Load ("PicPart3");
		p4 = (Texture)Resources.Load ("PicPart4");
		pic1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		pic2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		pic3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		pic4 = GameObject.CreatePrimitive (PrimitiveType.Cube);

		pic1.transform.position = new Vector3 (8.49f, 0f, 0.196f);
		pic1.transform.localScale = new Vector3 (0.22f, -0.0008688352f, 0.22f);
		pic1.AddComponent<GetPhoto> ();
		pic1.GetComponent<Renderer> ().material.mainTexture = p1;
		// > alterar tamanho do collider
		pic1.GetComponent<BoxCollider> ().center = new Vector3 (-0.1546296f, -694.6168f, -0.06930692f);
		pic1.GetComponent<BoxCollider>().size = new Vector3(3.394812f, -1389.235f, 3.345945f);
		pic1.GetComponent<BoxCollider> ().isTrigger = true;
		pic1.name = "photo1";

		pic2.transform.localScale = new Vector3 (0.22f, -0.0008688352f, 0.22f);
		pic2.transform.position = new Vector3 (5.998f, 1.068f, -8.459f);
		pic2.AddComponent<GetPhoto> ();
		pic2.GetComponent<Renderer> ().material.mainTexture = p2;
		pic2.GetComponent<BoxCollider> ().center = new Vector3 (-0.1601718f, -85.68013f, -0.2314351f);
		pic2.GetComponent<BoxCollider> ().size = new Vector3 (9.734653f, -170.3609f, 8.211736f);
		pic2.GetComponent<BoxCollider> ().isTrigger = true;
		pic2.name = "photo2";

		pic3.transform.localScale = new Vector3 (0.22f, -0.0008688352f, 0.22f);
		pic3.transform.position = new Vector3 (-9.05f, 0f, -8.72f);
		pic3.AddComponent<GetPhoto> ();
		pic3.GetComponent<Renderer> ().material.mainTexture = p3;
		pic3.GetComponent<BoxCollider> ().center = new Vector3 (0.7122126f, -630.3364f, 0.6758299f);
		pic3.GetComponent<BoxCollider> ().size = new Vector3 (5.067086f, -1262.046f, 5.438445f);
		pic3.GetComponent<BoxCollider> ().isTrigger = true;
		pic3.name = "photo3";

		pic4.transform.localScale = new Vector3 (0.22f, -0.0008688352f, 0.22f);
		pic4.transform.position = new Vector3 (-9.85f, 1.4f, 7.92f);
		pic4.transform.Rotate (90, 90, 0);
		pic4.AddComponent<GetPhoto> ();
		pic4.GetComponent<Renderer> ().material.mainTexture = p4;
		pic4.GetComponent<BoxCollider> ().center = new Vector3 (-0.9710268f, -435.0985f, 0f);
		pic4.GetComponent<BoxCollider> ().size = new Vector3 (8.896571f, 873.3066f, 3f);
		pic4.GetComponent<BoxCollider> ().isTrigger = true;
		pic4.name = "photo4";

	}

	public void CreateBarrels(){
		GameObject testParent = new GameObject();
		GameObject parent1 = new GameObject ();
		GameObject parent2 = new GameObject ();
		testParent.transform.position = new Vector3 (-6.94f, 0f, -7.85f);
		parent1.transform.position = new Vector3 (-9.107f, 0.519f, -8.721f);
		parent2.transform.position = new Vector3 (-8.87f, 0.63f, -7.3f);

		GameObject test = (GameObject)Instantiate (Resources.Load ("Barrel"));
		GameObject barrel1 = (GameObject)Instantiate (Resources.Load ("Barrel"));
		GameObject barrel2 = (GameObject)Instantiate (Resources.Load ("Barrel"));

		test.GetComponentInChildren<MeshCollider> ().convex = true;
		test.transform.position = new Vector3 (-7.31f, 0f, -8.2f);
		test.transform.parent = testParent.transform;
		testParent.AddComponent<Rigidbody> ();
		testParent.AddComponent<PickUp>();
		testParent.GetComponent<Rigidbody> ().freezeRotation = true;

		barrel1.GetComponentInChildren<MeshCollider> ().convex = true;
		barrel1.transform.position = new Vector3 (-9.448009f, 0.11f, -9.064977f);
		barrel1.transform.parent = parent1.transform;
		parent1.AddComponent<Rigidbody> ();
		parent1.AddComponent<PickUp> ();
		parent1.GetComponent<Rigidbody> ().freezeRotation = true;

		barrel2.GetComponentInChildren<MeshCollider> ().convex = true;
		barrel2.transform.position = new Vector3 (-9.243999f, 0.11f, -7.708f);
		barrel2.transform.parent = parent2.transform;
		parent2.AddComponent<Rigidbody> ();
		parent2.AddComponent<PickUp> ();
		parent2.GetComponent<Rigidbody> ().freezeRotation = true;
	}

	public void CreateWineHouses(){

		GameObject adega1 = (GameObject)Instantiate (Resources.Load ("B-I28/adega"));
		adega1.name = "adega1";
		adega1.transform.localScale = new Vector3 (0.09345359f, 0.09345359f, 0.09345359f);
		adega1.transform.position = new Vector3 (-8.61f, 0.02999997f, 3.83f);
		adega1.transform.rotation = Quaternion.identity;
		adega1.transform.Rotate (-90, 90, 0);
		adega1.AddComponent<Rigidbody> ();
		adega1.GetComponent<Rigidbody> ().isKinematic = true;
		adega1.AddComponent<BoxCollider> ();
		adega1.GetComponent<BoxCollider> ().center = new Vector3 (-13.87006f, 6.924312f, 18.8202f);
		adega1.GetComponent<BoxCollider> ().size = new Vector3 (27.75146f, 12.76708f, 30.13022f);
		adega1.AddComponent<Move> ();

		GameObject adega2 = (GameObject)Instantiate (Resources.Load ("B-I28/adega"));
		adega2.name = "adega2";
		adega2.transform.localScale = new Vector3 (0.09345359f, 0.09345359f, 0.09345359f);
		adega2.transform.position = new Vector3 (-8.61f, 0.02999997f, 6.46f);
		adega2.transform.rotation = Quaternion.identity;
		adega2.transform.Rotate (-90, 90, 0);
		adega2.AddComponent<Rigidbody> ();
		adega2.GetComponent<Rigidbody> ().isKinematic = true;
		adega2.AddComponent<BoxCollider> ();
		adega2.GetComponent<BoxCollider> ().center = new Vector3 (-14.2254f, 6.306799f, 18.8202f);
		adega2.GetComponent<BoxCollider> ().size = new Vector3 (29.00116f, 14.00228f, 30.13022f);
		adega2.AddComponent<Move> ();
	}

	public void CreatePaintings(){
		GameObject frame1, frame2, frame3, frame4, im1, im2, im3, p1, p2, p3, p4, back;
		Texture t1, t2, t3;
		// molduras
		frame1 = (GameObject)Instantiate (Resources.Load("Frame"));
		frame2 = (GameObject)Instantiate (Resources.Load("Frame"));
		frame3 = (GameObject)Instantiate (Resources.Load("Frame"));
		frame4 = (GameObject)Instantiate (Resources.Load("Frame"));

		t1 = (Texture)Resources.Load ("Vini");
		t2 = (Texture)Resources.Load ("Palomino");
		t3 = (Texture)Resources.Load ("Bronzato");

//		// planos para imagens dos quadros
		im1 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		im2 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		im3 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		p1 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		p2 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		p3 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		p4 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		back = GameObject.CreatePrimitive (PrimitiveType.Plane);

		//settando posições, escalas e rotações de todos os objetos
		frame1.transform.localScale = new Vector3 (0.2632115f, 0.2632115f, 0.2632115f);
		frame1.transform.position = new Vector3 (-3.14f, 1.3f, 9.03f);
		frame1.transform.Rotate (0, 90, 0);
		im1.transform.position = new Vector3 (-3.129472f, 1.929076f, 9.16687f);
		im1.transform.Rotate (90, 180, 0);
		im1.transform.localScale = new Vector3 (0.06267614f, 0.09886801f, 0.09542198f);
		im1.GetComponent<Renderer> ().material.mainTexture = t1;

		frame2.transform.localScale = new Vector3 (0.2632115f, 0.2632115f, 0.2632115f);
		frame2.transform.position = new Vector3 (-0.8059998f, 1.3f, 9.03f);
		frame2.transform.Rotate (0, 90, 0);
		im2.transform.position = new Vector3 (-0.7954713f, 1.929076f, 9.16687f);
		im2.transform.Rotate (90, 180, 0);
		im2.transform.localScale = new Vector3 (0.06267614f, 0.09886801f, 0.09542198f);
		im2.GetComponent<Renderer> ().material.mainTexture = t2;

		frame3.transform.localScale = new Vector3 (0.2632115f, 0.2632115f, 0.2632115f);
		frame3.transform.position = new Vector3 (1.41f, 1.3f, 9.03f);
		frame3.transform.Rotate (0, 90, 0);
		im3.transform.position = new Vector3 (1.420528f, 1.929076f, 9.16687f);
		im3.transform.Rotate (90, 180, 0);
		im3.transform.localScale = new Vector3 (0.06267614f, 0.09886801f, 0.09542198f);
		im3.GetComponent<Renderer> ().material.mainTexture = t3;

		GameObject rotationPoint = new GameObject ();
		frame4.transform.localScale = new Vector3 (0.2632115f, 0.2632115f, 0.2632115f);
		frame4.transform.position = new Vector3 (3.820461f, 1.3f, 9.03f);
		frame4.transform.Rotate (0, 90, 0);
		frame4.AddComponent<BoxCollider> ();
		frame4.name = "QuadroVazio";
		frame4.AddComponent<PaintingFrame> ();
		frame4.GetComponent<BoxCollider> ().center = new Vector3 (0.2770063f, 1.552899f, 0.1631429f);
		frame4.GetComponent<BoxCollider> ().size = new Vector3 (1.554606f, 4.105797f, 4.831037f);
		frame4.GetComponent<BoxCollider> ().isTrigger = true;

		p1.name = "picPart1";
		p2.name = "picPart2";
		p3.name = "picPart3";
		p4.name = "picPart4";

		p1.transform.localScale = new Vector3 (0.035f, 0.035f, 0.05999999f);
		p1.transform.position = new Vector3 (3.66f, 2.203f, 9.166f);
		p1.transform.Rotate (90, 180, 0);

		p2.transform.localScale = new Vector3 (0.035f, 0.035f, 0.05999999f);
		p2.transform.position = new Vector3 (4.009f, 2.203f, 9.166f);
		p2.transform.Rotate (90, 180, 0);

		p3.transform.localScale = new Vector3 (0.035f, 0.035f, 0.05999999f);
		p3.transform.position = new Vector3 (3.66f, 1.603f, 9.166f);
		p3.transform.Rotate (90, 180, 0);

		p4.transform.localScale = new Vector3 (0.035f, 0.035f, 0.05999999f);
		p4.transform.position = new Vector3 (4.009f, 1.603f, 9.166f);
		p4.transform.Rotate (90, 180, 0);

		back.transform.localScale = new Vector3 (0.06642528f, 0.1226351f, 0.09883665f);
		back.transform.Rotate (90, 0, 0);
		back.transform.position = new Vector3 (3.809f, 1.893f, 9.144f);

		rotationPoint.transform.position = new Vector3 (3.369569f, 1.972967f, 9.078835f);
		rotationPoint.AddComponent<Solved> ();	// adicionando script Solved
		frame4.transform.parent = rotationPoint.transform;
		p1.transform.parent = rotationPoint.transform;
		p2.transform.parent = rotationPoint.transform;
		p3.transform.parent = rotationPoint.transform;
		p4.transform.parent = rotationPoint.transform;
		back.transform.parent = rotationPoint.transform;

	}

	public void CreateGeneratorPuzzle(){
		GameObject gen, rwh, redL, greenL;

		rwh = (GameObject)Instantiate (Resources.Load ("RWH"));
		rwh.name = "RWH";
		rwh.transform.localScale = new Vector3 (3.854881f, 3.854881f, 3.854881f);
		rwh.transform.position = new Vector3 (8.5693f, 0.088f, 0.5f);

		gen = (GameObject)Instantiate (Resources.Load("Gen+Set"));
		gen.transform.position = new Vector3 (-6, -1.11f, 1.48f);
		gen.transform.localScale = new Vector3 (1.749209f, 1.749209f, 1.749209f);

		redL = GameObject.CreatePrimitive (PrimitiveType.Plane);
		greenL = GameObject.CreatePrimitive (PrimitiveType.Plane);

		redL.transform.localScale = new Vector3 (0.009821044f, 0.02904208f, 0.01934521f);
		redL.transform.position = new Vector3 (3.948f, 1.888f, 2.7397f);
		redL.transform.Rotate (-90, 0, 0);
		redL.GetComponent<Renderer> ().material.shader = Shader.Find ("Specular");
		redL.GetComponent<Renderer> ().material.SetColor ("_SpecColor", Color.red);

		greenL.transform.localScale = new Vector3 (0.009821044f, 0.02904208f, 0.01934521f);
		greenL.transform.position = new Vector3 (4.127f, 1.888f, 2.7397f);
		greenL.transform.Rotate (-90, 0, 0);
		greenL.GetComponent<Renderer> ().material.shader = Shader.Find ("Specular");
		greenL.GetComponent<Renderer> ().material.SetColor ("_SpecColor", Color.green);
		greenL.AddComponent<BoxCollider> ();
		greenL.GetComponent<BoxCollider> ().center = new Vector3 (-0.2776533f, 11.83692f, -14.75966f);
		greenL.GetComponent<BoxCollider> ().size = new Vector3 (38.54758f, -23.67453f, 39.03696f);
		greenL.GetComponent<BoxCollider> ().isTrigger = true;
		greenL.AddComponent<GenButton> ();
	}

	public void CreateInteractiveObjects(){
		GameObject vitrola, door;

		vitrola = (GameObject)Instantiate (Resources.Load("vitrola"));
		door = (GameObject)Instantiate (Resources.Load("porta"));

		vitrola.transform.localScale = new Vector3 (0.05154506f, 0.05154506f, 0.05154506f);
		vitrola.transform.rotation = Quaternion.identity;
		vitrola.transform.Rotate(-90, -540, 0);
		vitrola.transform.position = new Vector3 (-9.338f, 1.101f, -4.749f);
		vitrola.AddComponent<BoxCollider> ();
		vitrola.GetComponent<BoxCollider> ().center = new Vector3 (-2.98255f, -4.163259f, 13.1692f);
		vitrola.GetComponent<BoxCollider> ().size = new Vector3 (28.36096f, 30.45208f, 27.83895f);
		vitrola.GetComponent<BoxCollider> ().isTrigger = true;
		vitrola.AddComponent<VitrolaSound> ();

		door.transform.localScale = new Vector3 (0.5319688f, 0.5319688f, 0.5319688f);
		door.transform.rotation = Quaternion.identity;
		door.transform.Rotate(0, 180, 0);
		door.transform.position = new Vector3 (0.83f, 0, -9.524f);
		door.AddComponent<BoxCollider> ();
		door.GetComponent<BoxCollider> ().center = new Vector3 (1.53357f, 2.517775f, -0.534779f);
		door.GetComponent<BoxCollider> ().size = new Vector3 (3.441795f, 5.03555f, 1.501308f);
		door.GetComponent<BoxCollider> ().isTrigger = true;
		door.AddComponent<OpenDoor> ();
	}

	public void CreateStaticObjects(){
		GameObject desk, lamp, books, tools, toolbox, ladder, tv;

		desk = (GameObject)Instantiate (Resources.Load("RolltopDesk#1/model"));
		lamp = (GameObject)Instantiate (Resources.Load("Untitled/lamparina"));
		books = (GameObject)Instantiate (Resources.Load("old+books/model"));
		tools = (GameObject)Instantiate (Resources.Load("tools"));
		toolbox = (GameObject)Instantiate (Resources.Load("toolbox"));
		ladder = (GameObject)Instantiate (Resources.Load("ladder-small/model"));
		tv = (GameObject)Instantiate (Resources.Load("Planastonic+PT-1181/model"));

		desk.transform.localScale = new Vector3 (0.03424006f, 0.03424006f, 0.03424006f);
		desk.transform.rotation = Quaternion.identity;
		desk.transform.Rotate(-90, 0, 0);
		desk.transform.position = new Vector3 (7.7346f, 0, -10.58f);

		lamp.transform.localScale = new Vector3 (0.02659329f, 0.02659329f, 0.02659329f);
		lamp.transform.rotation = Quaternion.identity;
		lamp.transform.Rotate(-90, 0, 0);
		lamp.transform.position = new Vector3 (6.078f, 1.05f, -8.551f);

		books.transform.localScale = new Vector3 (0.0308007f, 0.0236732f, 0.01832133f);
		books.transform.rotation = Quaternion.identity;
		books.transform.Rotate(-90, 0, 0);
		books.transform.position = new Vector3 (4.2f, 0, -9.6f);

		tools.transform.localScale = new Vector3 (0.03287176f, 0.02729443f, 0.02729443f);
		tools.transform.rotation = Quaternion.identity;
		tools.transform.Rotate(0, 90, 0);
		tools.transform.position = new Vector3 (-12.661f, 7.3485f, 0.759f);

		toolbox.transform.localScale = new Vector3 (0.02951925f, 0.02951925f, 0.02951925f);
		toolbox.transform.rotation = Quaternion.identity;
		toolbox.transform.Rotate(-90, 0, 0);
		toolbox.transform.position = new Vector3 (-9.12f, 0, -4.18f);

		ladder.transform.localScale = new Vector3 (0.04363078f, 0.04363078f, 0.04363078f);
		ladder.transform.rotation = Quaternion.identity;
		ladder.transform.Rotate(-70.4386f, 0, 0);
		ladder.transform.position = new Vector3 (-5.5179f, 0.07f, 7.84f);

		tv.transform.localScale = new Vector3 (0.03930718f, 0.03930718f, 0.03930718f);
		tv.transform.rotation = Quaternion.identity;
		tv.transform.Rotate(-90, -90, 0);
		tv.transform.position = new Vector3 (8.517f, 0, 9.22f);
	}
}
