using UnityEngine;
using System.Collections;

public class FleePacman : MonoBehaviour {
	public GameObject pacman;
	public MoveScript pacmanMove;
	public float shortestDistance = 0;
	public Vector3 pacmanPos;
	public Vector3 CurrentShortestVector;
	//Target is only used to check if the current script is working, should be removed in release.
	public Vector3 target;
	public Vector3[] Corners;
	// Use this for initialization
	void Start () {
		target = new Vector3(0,0,0);
		Corners[0] = new Vector3(-38.5f, 1.64f, -23.5f);
		Corners[1] = new Vector3(-38.5f, 1.64f, 23.5f);
		Corners[2] = new Vector3(23.1f, 1.64f, 28.1f);
		Corners[3] = new Vector3(22f, 1.64f, -27.6f);
		pacmanMove = pacman.GetComponent<MoveScript>();
		Debug.Log(Vector3.Distance(pacmanPos,Corners[0]));
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void pacmanFlee(string Ghost){
		Debug.Log ("Initializing flee coordinates for ghost number" + Ghost);
		pacmanPos = new Vector3(pacman.transform.position.x, pacman.transform.position.y, pacman.transform.position.z);
		for(int i = 0; i < 4; i++){
			if(shortestDistance == 0){
				shortestDistance = Vector3.Distance(pacmanPos,Corners[i]);
				CurrentShortestVector = Corners[i];
			} else if (Vector3.Distance(Corners[i],CurrentShortestVector) <= shortestDistance){
				CurrentShortestVector = Corners[i];
				shortestDistance = Vector3.Distance(Corners[i],CurrentShortestVector);
			}
		}

	}
}
