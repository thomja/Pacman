using UnityEngine;
using System.Collections;

public class GlobalPointScript : MonoBehaviour {
	public GUIStyle style;
	public int score = 0;
	public int lives = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.Label(new Rect(0, 0, 200, 50), "Poäng: " + score + " and " + lives + "lives", style);        
	}
}
