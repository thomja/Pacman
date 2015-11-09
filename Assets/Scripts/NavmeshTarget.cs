using UnityEngine;
using System.Collections;

public class NavmeshTarget : MonoBehaviour {
	public GameObject pacman;
	private NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(pacman.transform.position);
	}
}
