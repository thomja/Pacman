using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public int myDirection = 0;
	public float speed;
	public GameObject[] travDirectionBox;
	public BoxChecker[] myBoxes;
	// Use this for initialization
	void Start () {
		myBoxes[0] = travDirectionBox[0].GetComponent<BoxChecker>();
		myBoxes[1] = travDirectionBox[1].GetComponent<BoxChecker>();
		myBoxes[2] = travDirectionBox[2].GetComponent<BoxChecker>();
		myBoxes[3] = travDirectionBox[3].GetComponent<BoxChecker>();
		speed = 0.04f;
	}

	void speedReset(){
		if(speed == 0f){
			speed = 0.04f;
		}
	}

	public int ChangeDirection(int newDirection){
		if(newDirection == 1 && myBoxes[0].isColliding <= 0){
			speedReset();
			return(5);
		} else if (newDirection == 2 && myBoxes[1].isColliding <= 0){
			transform.Rotate(0f, 180f, 0f);
			speedReset();
			return(5);
		} else if (newDirection == 3 && myBoxes[2].isColliding <= 0){
			transform.Rotate(0f, -90f, 0f);
			speedReset();
			return(5);
		} else if (newDirection == 4 && myBoxes[3].isColliding <= 0){
			transform.Rotate(0f, 90f, 0f);
			speedReset();
			return(5);
		}
		return(myDirection);
	}

	// Update is called once per frame
	void Update () {
		if(myDirection == 0){

		} else {
			transform.Translate(new Vector3(0f,0f,1f) * speed);
			myDirection = ChangeDirection(myDirection);
		}
		if(Input.GetKeyDown(KeyCode.W)){
			myDirection = 1;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			myDirection = 2;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			myDirection = 3;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			myDirection = 4;
		}
	}

	void OnCollisionEnter(Collision myColl){
		if(myColl.gameObject.tag == "Wall" && myBoxes[0].isColliding > 0){
			speed = 0f;
		}
	}
}
