using UnityEngine;
using System.Collections;

public class FollowPacman : MonoBehaviour {

	//target som kameran ska följa
	public Transform target;
	//avstånden mellan kameran och pacman
	public float distance = 8;
	// höjden man vill ha ovan pacman
	public float height = 6.8f;
	//dämpning
	//public float heightDamping = 3;
	public float rotationDamping = 3;

	void Update () 
	{
		if (target)
		{
			// kalkylera löpande rotations vinklar
			float wantedRotationAngle = target.eulerAngles.y;
			float currentRotationAngle = transform.eulerAngles.y;
			float currentHeight = transform.position.y;
			
			// dämper rotationen i y-axeln
			currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
			Quaternion currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);

			//positionen för kameran
			Vector3 pos = target.position;
			pos -= currentRotation * Vector3.forward * distance;
			pos.y = currentHeight;
			transform.position = pos;
			
			
			// alltid tittar på Pacman
			transform.LookAt (target);
		}
	}
	
	
}