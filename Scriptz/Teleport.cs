using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public float x;
	public float y;
	public float z;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Pacman") {
			col.gameObject.transform.position = new Vector3(z,y,z);
			Debug.Log("teleported");
		}
	}
}
