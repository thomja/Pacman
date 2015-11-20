using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Highscore : MonoBehaviour
{
    private const int LeaderboardLength = 10;
    private bool highscore = false;
    
    

    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
