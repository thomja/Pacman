using UnityEngine;
using System.Collections;

public class Teleprot : MonoBehaviour {
	public float x;
	public float y;
	public float z;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCillisonEnter(Collision Col){
		if(Col.gameObject.name == "Pacman"){
			Col.gameObject.transform.position = new Vector3(z,y,z);
		}
	}
}
