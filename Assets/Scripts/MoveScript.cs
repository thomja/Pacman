using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public bool canRestart;
	public int myDirection = 0;
	public float speed = 1;
	public bool moveForward;
	public GameObject _SCRIPT;
	public GlobalPointScript pointScript;
	public bool hasPower;
	public GameObject[] myBoxes;
	public BoxChecker[] myBoxCheckers;
	public float[] startCoords;
<<<<<<< HEAD
	public GUIStyle style;
	public string failString;
	// Use this for initialization
	void Start () {
		failString = "";
		startCoords[0] = transform.position.x;
		startCoords[1] = transform.position.y;
		startCoords[2] = transform.position.z;
		pointScript = GameObject.Find("_SCRIPTS").GetComponent<GlobalPointScript>();
=======
	public GameObject[] Ghosts;
	// Use this for initialization
	void Start () {
		startCoords[0] = transform.position.x;
		startCoords[1] = transform.position.y;
		startCoords[2] = transform.position.z;
		pointScript = _SCRIPT.GetComponent<GlobalPointScript>();
>>>>>>> origin/Thomas_Branch
		myBoxCheckers[0] = myBoxes[0].GetComponent<BoxChecker>();
		myBoxCheckers[1] = myBoxes[1].GetComponent<BoxChecker>();
		myBoxCheckers[2] = myBoxes[2].GetComponent<BoxChecker>();
	}
	/*
	void instantiantor(Typ av array, Typ av script, Funktionen ){

	}*/

	void CheckTurn(){
		if(myDirection == 1 && myBoxCheckers[1].boxClear == true){
			transform.Rotate(0f, 90f, 0f);
			myDirection = 0;
		} else if (myDirection == 2 && myBoxCheckers[2].boxClear == true){
			transform.Rotate(0f, -90f, 0f);
			myDirection = 0;
		}
	}

	// Update is called once per frame
	void Update () {
		CheckTurn();
		if(myBoxCheckers[0].boxClear == true && moveForward == true){
			transform.Translate(new Vector3(0f,0f,1f) * speed);
		}
		if(Input.GetKeyDown(KeyCode.W)){
			moveForward = true;
		}
		if(Input.GetKeyDown(KeyCode.S) && pointScript.lives > 0){
			transform.Rotate(0f, 180f, 0f);
			myDirection = 0;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			myDirection = 2;
			CheckTurn();
		}
		if(Input.GetKeyDown(KeyCode.D)){
			myDirection = 1;
			CheckTurn();
		}
		if(Input.GetKey(KeyCode.Space)){
			if(canRestart == true){
				canRestart = false;
				Time.timeScale = 1;
				pointScript.lives = 3;
				pointScript.score = 0;
				failString = "";
			}
		}
	}

	void OnTriggerEnter(Collider Coll){
<<<<<<< HEAD
		if(Coll.gameObject.tag == "Ghost" && this.gameObject.name == "Pacman"){
			pointScript.lives -= 1;
			transform.position = new Vector3(startCoords[0], startCoords[1], startCoords[2]);
			transform.rotation = Quaternion.LookRotation(Vector3.forward);
			moveForward = false;
			pointScript.resetAllGhosts();
			if(pointScript.lives <= 0){
				failString = "Game over, press space to restart!";
				canRestart = true;
				Time.timeScale = 0;
			}
		} else if (Coll.gameObject.tag == "SuperPill" && this.gameObject.name == "Pacman"){
			Debug.Log ("Initializing FleeStage");
			hasPower = true;
			for(int i = 0; i < 4; i++){
				if(pointScript.myGhosts[i].hasStarted == true){
					pointScript.myGhosts[i].fleePacman.pacmanFlee(i.ToString());
					pointScript.myGhosts[i].agent.SetDestination(pointScript.myGhosts[i].fleePacman.CurrentShortestVector);
				}
			}
		}
	}
	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 200, 50), failString, style);        
	}
=======
		if(Coll.gameObject.tag == "Ghost"){
			pointScript.lives -= 1;
			transform.position = new Vector3(startCoords[0],startCoords[1],startCoords[2]);
			transform.rotation = Quaternion.Euler(0, 0, 0);
			moveForward = false;
		}
	}



>>>>>>> origin/Thomas_Branch
}
