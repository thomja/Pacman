using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
   

    public string rankString, usernameString, scoreString;
    public string Place, Username, Score;

    void Start()
    {
        Place = rankString;
        Username = usernameString;
        Score = scoreString;
    }
}
