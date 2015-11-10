using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public int myDirection = 0;
	public float speed = 1;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0f,0f,1f) * speed);
		}
		if(Input.GetKeyDown(KeyCode.S)){
			transform.Rotate(0f, 180f, 0f);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0f, -3f, 0f);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0f, 3f, 0f);
		}
		if(Input.GetKey(KeyCode.E)){
			speed = speed / 2;
			transform.Translate(new Vector3(1f,0f,0f) * speed);
		}
		if(Input.GetKey(KeyCode.Q)){
			speed = speed / 2;
			transform.Translate(new Vector3(-1f,0f,0f) * speed);
		}
	}
}
