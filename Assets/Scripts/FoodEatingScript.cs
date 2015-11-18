using UnityEngine;
using System.Collections;

public class FoodEatingScript : MonoBehaviour {
	private int yAxis;
	public GlobalPointScript pointScript;
	public int scoreAmount;
	public int localScore = 0;
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
			localScore += scoreAmount;
			if(localScore >= 500){
				pointScript.lives += 1;
				localScore = 0;
			}
			Destroy(gameObject);
		}
	}
}
