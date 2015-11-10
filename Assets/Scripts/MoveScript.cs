using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public int myDirection = 0;
	public float speed = 1;
	private bool hasStarted;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		if(hasStarted == true){
			transform.Translate(new Vector3(0f,0f,1f) * speed);
		}
		if(Input.GetKeyDown(KeyCode.W)){
			hasStarted = true;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			transform.Rotate(0f, 180f, 0f);
		}
		if(Input.GetKeyDown(KeyCode.A)){
			transform.Rotate(0f, -90f, 0f);
		}
		if(Input.GetKeyDown(KeyCode.D)){
			transform.Rotate(0f, 90f, 0f);
		}
	}
}
