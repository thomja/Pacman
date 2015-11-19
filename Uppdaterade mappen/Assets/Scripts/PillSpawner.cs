using UnityEngine;
using System.Collections;

public class PillSpawner : MonoBehaviour {

	public GameObject myPill;
	public float xAxis = 0.0f;
	public bool done = false;

	void spawnPill(Vector3 position){
		Instantiate(myPill, position, Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < 10; i++){
			if(done == false){
				spawnPill(new Vector3(i,xAxis, 18.133f));
				xAxis++;
				Debug.Log (i);
			}
			if(i == 9){
				done = true;
			}
		}
	}
}
