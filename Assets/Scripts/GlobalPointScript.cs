using UnityEngine;
using System.Collections;

public class GlobalPointScript : MonoBehaviour {
	public GUIStyle style;
	public int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.Label(new Rect(0, 0, 200, 50), "Poäng: " + score, style);        
	}
}
