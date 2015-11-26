using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public int score;
    public int[] highscore = new int[10];
    public Text pointText;

    void Awake()
    {
        score = Move.points;
        PlayerPrefs.SetInt("pointText",0);
        SetpointText();
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

    void SetpointText()
    {
        pointText.text = "" + score.ToString();
    }
}
