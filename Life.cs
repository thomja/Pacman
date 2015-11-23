using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private int points, lives;
    public Text pointText, livesText, Life1Text, Life2Text, Life3Text, Life4Text;
    private GameObject Pill, Fruit;
    static bool gameover, extraLife, loselife1, loselife2, loselife3, loselife4;
    public Image Life1, Life2, Life3, Life4;


    void Awake()
    {
        extraLife = true;
        lives = 3;
        points = 0;
        SetpointText();
    }
    void SetpointText()
    {
        pointText.text = "Spelare 1:   " + points.ToString();
        livesText.text = "Life: " + lives.ToString();
        Life1Text.text = "Life: " + lives.ToString();
        Life2Text.text = "Life: " + lives.ToString();
        Life3Text.text = "Life: " + lives.ToString();
        Life4Text.text = "Life: " + lives.ToString();
    }

    void Update()
    {
        if (lives <= 0) // Om man inte har några liv så blir gameover true
        {
            gameover = true;
        }
        if (gameover) // Laddar en ny scen som heter Highscore
        {
            Application.LoadLevel("Highscore");
        }
        if () // Förutsättning för att förlora första livet
        {
            if (loselife1 == false)
            {
                lives--;
                loselife1 = true;
                SetpointText();
            }
        }
        if () // Förutsättning för att förlora andra livet
        {
            if (loselife2 == false)
            {
                lives--;
                loselife2 = true;
                SetpointText();
            }
        }
        if (lives == 3) // Förutsättning för att förlora tredje livet
        {
            if (loselife3 == false)
            {
                lives--;
                loselife3 = true;
                SetpointText();
            }
        }
        if () // Förutsättning för att förlora fjärde livet
        {
            if (loselife4 == false)
            {
                lives--;
                loselife4 = true;
                SetpointText();
            }
        }

        if (extraLife == true)
        {
            if () // Förutsättning för att få extraliv
            {
                lives++;
                extraLife = false;
                SetpointText();
            }

        }
        if (lives == 1) // Om man har ett liv så visas Image1
        {
            Life1.enabled = true;
            Life2.enabled = false;
            Life3.enabled = false;
            Life4.enabled = false;
            SetpointText();
        }
        if (lives == 2) // Om man har två liv så visas Image2
        {
            Life1.enabled = false;
            Life2.enabled = true;
            Life3.enabled = false;
            Life4.enabled = false;
            SetpointText();
        }
        if (lives == 3) // Om man har tre liv så visas Image3
        {
            Life1.enabled = false;
            Life2.enabled = false;
            Life3.enabled = true;
            Life4.enabled = false;
            SetpointText();
        }
        if (lives == 4) // Om man har fyra liv så visas Image4
        {
            Life1.enabled = false;
            Life2.enabled = false;
            Life3.enabled = false;
            Life4.enabled = true;
            SetpointText();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Pill")
        {
            points += 10;
            Destroy(col.gameObject);
            SetpointText();

        }
        if (col.gameObject.tag == "Fruit")
        {
            points += 500;
            Destroy(col.gameObject);
            SetpointText();
        }
    }
}