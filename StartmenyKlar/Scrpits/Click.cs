using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Click : MonoBehaviour
{

    public void OnClickQuit()
    {
        Application.Quit();
    }
    public void OnClickStart()
    {
        Application.LoadLevel("Score");
    }
    public void OnClickHighscore()
    {
        Application.LoadLevel("Highscore");
    }
    public void OnClickOptions()
    {
        Application.LoadLevel("Options");
    }
    public void OnClickStartmenu()
    {
        Application.LoadLevel("Startmenu");
    }

}
