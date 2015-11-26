using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Liv : MonoBehaviour
{
    public static int lives, points;
    public Image Life1, Life2, Life3, Life4;
    static bool gameover, extraLife, loselife1, loselife2, loselife3, loselife4;

    void Awake()
    {
        loselife1 = false;
        loselife2 = false;
        loselife3 = false;
        loselife4 = false;
        gameover = false;
        extraLife = true;
        lives = 3;
    }
    
    public void Update()
    {
        if (lives == 0) // Om man inte har några liv så blir gameover true
        {
            gameover = true;
        }
        if () // Förutsättning för att förlora första livet
        {
            if (loselife1 == false)
            {
                lives--;
                loselife1 = true;
            }
        }
        if () // Förutsättning för att förlora andra livet
        {
            if (loselife2 == false)
            {
                lives--;
                loselife2 = true;
            }
        }
        if () // Förutsättning för att förlora tredje livet
        {
            if (loselife3 == false)
            {
                lives--;
                loselife3 = true;
            }
        }
        if () // Förutsättning för att förlora fjärde livet
        {
            if (loselife4 == false)
            {
                lives--;
                loselife4 = true;
            }
        }

        if (extraLife == true)
        {
            if () // Förutsättning för att få extraliv
            {
                lives++;
                extraLife = false;
            }

        }
        if (lives == 1) // Om man har ett liv så visas Image1
        {
            Life1.enabled = true;
            Life2.enabled = false;
            Life3.enabled = false;
            Life4.enabled = false;
        }
        if (lives == 2) // Om man har två liv så visas Image2
        {
            Life1.enabled = false;
            Life2.enabled = true;
            Life3.enabled = false;
            Life4.enabled = false;
        }
        if (lives == 3) // Om man har tre liv så visas Image3
        {
            Life1.enabled = false;
            Life2.enabled = false;
            Life3.enabled = true;
            Life4.enabled = false;
        }
        if (lives == 4) // Om man har fyra liv så visas Image4
        {
            Life1.enabled = false;
            Life2.enabled = false;
            Life3.enabled = false;
            Life4.enabled = true;
        }
    }
}
