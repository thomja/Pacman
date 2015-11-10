using UnityEngine;
using System.Collections;

public class CameraShader : MonoBehaviour {
	public Shader myShader;
	// Use this for initialization
	void Start () {
		myShader.
		GetComponent<Camera>().SetReplacementShader(myShader,"");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
