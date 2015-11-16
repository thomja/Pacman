using UnityEngine;
using System.Collections;

public class PacmanIntroRotate : MonoBehaviour {
	public GameObject pacman;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,1,0);
	}
}
