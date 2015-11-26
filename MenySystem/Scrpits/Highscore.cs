using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Highscore : MonoBehaviour
{
    public int[] highscore = new int[10];
    public Text highpointText;
    public static int highpoints;

    void Start()
    {
        highpoints = PlayerPrefs.GetInt("playerscore", 0);
        SetpointText();
    }

    public void checkhighscore()
    {
        for (int i = 0; i < highscore.Length; i++)
        {
            if (highpoints > highscore[i])
            {
                
            }
        }
    }
    public void Update()
    {
        SetpointText();
    }

    public void SetpointText()
    {
        highpointText.text = "" + highpoints.ToString();
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
