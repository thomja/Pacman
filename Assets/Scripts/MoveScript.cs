using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public int myDirection = 0;
	public float speed = 1;
	public bool moveForward;
	public GlobalPointScript pointScript;
	public bool hasPower;
	public GameObject[] myBoxes;
	public BoxChecker[] myBoxCheckers;
	public float[] startCoords;
	// Use this for initialization
	void Start () {
		startCoords[0] = transform.position.x;
		startCoords[1] = transform.position.y;
		startCoords[2] = transform.position.z;
		pointScript = GameObject.Find("_SCRIPTS").GetComponent<GlobalPointScript>();
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
		if(Input.GetKeyDown(KeyCode.S)){
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
	}

	void OnTriggerEnter(Collider Coll){
		if(Coll.gameObject.tag == "Ghost" && this.gameObject.name == "Pacman"){
			pointScript.lives -= 1;
			transform.position = new Vector3(startCoords[0], startCoords[1], startCoords[2]);
			transform.rotation = Quaternion.LookRotation(Vector3.forward);
			moveForward = false;
			pointScript.resetAllGhosts();
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
}
