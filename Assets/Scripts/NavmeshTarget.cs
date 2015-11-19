using UnityEngine;
using System.Collections;

public class NavmeshTarget : MonoBehaviour {
	public bool hasStarted;
	public GameObject pacman;
	public NavMeshAgent agent;
	public int targetChecker;
	public int waitTimer;
	public float[] startCoords;
	public GameObject _SCRIPT;
	public FleePacman fleePacman;
	// Use this for initialization
	void Start () {
		startCoords[0] = transform.position.x;
		startCoords[1] = transform.position.y;
		startCoords[2] = transform.position.z;
		agent = GetComponent<NavMeshAgent>();
		fleePacman = _SCRIPT.GetComponent<FleePacman>();
		InvokeRepeating("setTarget",waitTimer,6);
	}

	void setTarget(){
		if(fleePacman.pacmanMove.hasPower == false){
			hasStarted = true;
			targetChecker = Random.Range (1,4);
			if(targetChecker == 1){
				agent.SetDestination(fleePacman.Corners[Random.Range (0,3)]);
			}else{
				agent.SetDestination(pacman.transform.position);
			}
		}
	}

	public void startOver(){
		transform.position = new Vector3(startCoords[0], startCoords[1], startCoords[2]);
		transform.rotation = Quaternion.LookRotation(Vector3.forward);
		CancelInvoke("SetTarget");
		InvokeRepeating("setTarget",waitTimer,3);
	}

	// Update is called once per frame
	void Update () {
		//Should maybe set the in a InvokeRepeating for performance.
		if(transform.position == fleePacman.target &&
		   fleePacman.pacmanMove.hasPower == true){
		}
		if(transform.position == agent.destination && hasStarted == true){
			setTarget ();
		}
	}
}
