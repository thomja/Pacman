using UnityEngine;
using System.Collections;

public class NavmeshTarget : MonoBehaviour {
	public GameObject pacman;
	private NavMeshAgent agent;
	public int waitTimer;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		InvokeRepeating("setTarget",waitTimer,10);
	}
	void setTarget(){
		agent.SetDestination(pacman.transform.position);
	}
	// Update is called once per frame
	void Update () {

	}
}
