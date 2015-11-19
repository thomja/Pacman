using UnityEngine;
using System.Collections;

public class Hitbox : MonoBehaviour {
	public GameObject Pacman;
	public MoveScript PacmanMove;
	// Use this for initialization
	void Start () {
	PacmanMove = Pacman.GetComponent<MoveScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Coll){
		if(Coll.gameObject.tag == "Ghost" && this.gameObject.name == "Hitbox"){
			PacmanMove.pointScript.lives -= 1;
			transform.position = new Vector3(PacmanMove.startCoords[0], PacmanMove.startCoords[1], PacmanMove.startCoords[2]);
			transform.rotation = Quaternion.LookRotation(Vector3.forward);
			PacmanMove.moveForward = false;
		}
	}
}
