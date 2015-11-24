using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Highscore : MonoBehaviour
{
    public int score;
    public int[] highscore = new int[10];
    
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < highscore.Length; i++)
        {
            if (score > highscore[i])
            {
                
            }
        }
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
