using UnityEngine;
using System.Collections;

public class FoodEatingScript : MonoBehaviour {
	private int yAxis;
	public GlobalPointScript pointScript;
	public int scoreAmount;
	// Use this for initialization
	void Start () {
		pointScript = GameObject.Find("_SCRIPTS").GetComponent<GlobalPointScript>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time / 2, 1) + 1,transform.position.z);
		transform.Rotate(0,1.5f,0);
	}
	void OnTriggerEnter(Collider myColl){
		Debug.Log (myColl.gameObject.name);
		if(myColl.gameObject.name == "Eater"){
			pointScript.score = pointScript.score + scoreAmount;
			Destroy(gameObject);
		}
	}
}
