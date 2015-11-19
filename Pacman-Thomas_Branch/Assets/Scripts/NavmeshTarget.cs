using UnityEngine;
using System.Collections;

public class NavmeshTarget : MonoBehaviour {
	public GameObject pacman;
	private NavMeshAgent agent;
	public int waitTimer;
	public float[] startCoords;
	// Use this for initialization
	void Start () {
		startCoords[0] = transform.position.x;
		startCoords[1] = transform.position.y;
		startCoords[2] = transform.position.z;
		agent = GetComponent<NavMeshAgent>();
		InvokeRepeating("setTarget",waitTimer,10);
	}
	void setTarget(){
		agent.SetDestination(pacman.transform.position);
	}
	// Update is called once per frame
	void Update () {

	}

	void PacmanCaught(){
		transform.position = new Vector3(startCoords[0],startCoords[1],startCoords[2]);
	}
}
