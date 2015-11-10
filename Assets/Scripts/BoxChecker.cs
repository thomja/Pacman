using UnityEngine;
using System.Collections;

public class BoxChecker : MonoBehaviour {
	public int isColliding = 0;
	public GameObject Pacman;
	MoveScript myMoveScript;
	// Use this for initialization
	void Start () {
		myMoveScript = Pacman.GetComponent<MoveScript>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerExit(){
		isColliding -= 1;
	}

	void OnTriggerEnter(Collider Col){
		isColliding += 1;
	}
}
