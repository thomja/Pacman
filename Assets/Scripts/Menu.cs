using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	public void OnClick(){
		if(this.gameObject.name == "Start"){
			Application.LoadLevel(1);
		} else if (this.gameObject.name == "Highscore"){

		}else if (this.gameObject.name == "Options"){

		}else if (this.gameObject.name == "Quit"){
			Application.Quit();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
