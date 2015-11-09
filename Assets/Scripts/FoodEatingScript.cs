using UnityEngine;
using System.Collections;

public class FoodEatingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider myColl){
		Debug.Log (myColl.gameObject.name);
		if(myColl.gameObject.name == "Eater"){
			Destroy(gameObject);
		}
	}
}
