using UnityEngine;
using System.Collections;

public class HitPoints : MonoBehaviour {

	public Texture life1;
	public Texture life2;
	public Texture life3;
	private int currentLife;
	void Start () {
		currentLife = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentLife == 2) {
			life3 = null;
		} else 
		if (currentLife == 1) {
			life2 = null;
		} else
		if (currentLife == 0) {
			life1 = null;
			//Application.LoadLevel("GameOver");
		}
	}
	void OnGUI() {
		GUI.DrawTexture(new Rect(10, 500, 60, 60), life1);
		GUI.DrawTexture(new Rect(70, 500, 60, 60), life1);
		GUI.DrawTexture(new Rect(130, 500, 60, 60), life1);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Ghost")
		{
			currentLife -= 1;
		}
	}
}
