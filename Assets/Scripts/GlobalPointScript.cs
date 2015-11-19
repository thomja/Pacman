using UnityEngine;
using System.Collections;

public class GlobalPointScript : MonoBehaviour {
	public GUIStyle style;
	public int score = 0;
	public int lives = 3;
	public GameObject[] Ghosts;
	public NavmeshTarget[] myGhosts;
	// Use this for initialization
	void Start () {
		myGhosts[0] = Ghosts[0].GetComponent<NavmeshTarget>();
		myGhosts[1] = Ghosts[1].GetComponent<NavmeshTarget>();
		myGhosts[2] = Ghosts[2].GetComponent<NavmeshTarget>();
		myGhosts[3] = Ghosts[3].GetComponent<NavmeshTarget>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void resetAllGhosts(){
		for(int i = 0; i < myGhosts.Length; i++){
			myGhosts[i].startOver();
		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(0, 0, 200, 50), "Poäng: " + score + " and " + lives + " lives", style);        
	}
}
