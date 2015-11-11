using UnityEngine;
using System.Collections;

public class BoxChecker : MonoBehaviour {
	public int isColliding = 0;
	public bool boxClear;
	// Use this for initialization
	void Start () {
		boxClear = true;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerExit(Collider Col){
		if(Col.gameObject.tag != "Terrain"){
			isColliding -= 1;
			if(isColliding == 0){
				boxClear = true;
			}
		}
	}

	void OnTriggerEnter(Collider Col){
		if(Col.gameObject.tag != "Terrain"){
			isColliding += 1;
			boxClear = false;
		}
	}
}
