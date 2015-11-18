using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private bool mainMenu = true;
	private bool options = false;
	private bool highscore = false;
	private bool quality = false;
	private bool keybind = false;

	void OnGUI(){
		if (mainMenu) {
			if (GUI.Button (new Rect (15, 15, 130, 50), "Start")) {
				//Application.LoadLevel("Pacman");
			}

			if (GUI.Button (new Rect (15, 65, 130, 50), "Highscore")) {
				mainMenu = false;
				highscore = true;
				//andreas script?
			}

			if (GUI.Button (new Rect (15, 165, 130, 50), "Quit")) {
				Application.Quit();
			}
			if (GUI.Button (new Rect (15, 115, 130, 50), "Options")) {
				mainMenu = false;
				options = true;
			}
		}

		if(options){
				if (GUI.Button (new Rect (15, 15, 130, 50), "Quality")){
					options = false;
					quality = true;
				}
				if (GUI.Button (new Rect (15, 65, 130, 50), "Keybinds")){
					options = false;
					keybind = true;
				}
				if (GUI.Button (new Rect (15, 115, 130, 50), "Back to MainMenu")){
					options = false;
					mainMenu = true;
				}
		}

		if (quality) {
			var qualities = QualitySettings.names;

			for(var i = 0; i < qualities.Length; i++){
				if(GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 - 120 + i * 30, 130, 30), qualities[i])){
					QualitySettings.SetQualityLevel (i, true);
				}
			}
			if (GUI.Button (new Rect (15, 215, 100, 50), "Back")){
				quality = false;
				options = true;
			}
		}
		if (keybind) {
			GUI.Label(new Rect(10, 10, 200, 100), "W - Move Forward\nS - Move Backwards\nD - Move Right\nA - Move Left");
			if (GUI.Button (new Rect (15, 115, 100, 50), "Back")){
				keybind = false;
				options = true;
			}
		}
	}
}
