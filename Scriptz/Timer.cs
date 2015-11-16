using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public Rect timerPosition;
	public float startTime = 10;
	public GUISkin guiSkin;
	private string currentTime;
	private float timePoints;
	private bool updateTimer = false;

	void Start(){
		updateTimer = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (updateTimer == true) 
		{
			startTime -= Time.deltaTime;
			currentTime = string.Format ("{0:0}", startTime);
		}
		//spelaren förlora på tid
		if (startTime <= 0) {
			startTime = 0;
			currentTime = "";//gör så att timern försvinner när den är 0
			//Application.LoadLevel("GameOver");
		}
	}

	void OnGUI()
	{
		GUI.skin = guiSkin;
		GUI.Label (timerPosition, currentTime);
	}
}
