using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public int myDirection = 0;
	public float speed = 1;
	public bool moveForward;
	public GameObject[] myBoxes;
	public BoxChecker[] myBoxCheckers;
	// Use this for initialization
	void Start () {
		myBoxCheckers[0] = myBoxes[0].GetComponent<BoxChecker>();
		myBoxCheckers[1] = myBoxes[1].GetComponent<BoxChecker>();
		myBoxCheckers[2] = myBoxes[2].GetComponent<BoxChecker>();
	}

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
}
