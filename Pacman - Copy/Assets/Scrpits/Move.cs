using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public static int points, lives;
    public Text pointText, livesText;
    private GameObject Pill, Fruit;
    static bool gameover, extraLife, loselife1, loselife2, loselife3, loselife4;
    public Image Life1, Life2, Life3, Life4;
    public Rigidbody Ball;
    
    void Awake()
    {
        loselife1 = false;
        loselife2 = false;
        loselife3 = false;
        loselife4 = false;
        gameover = false;
        extraLife = true;
        lives = 3;
        points = 0;
        SetpointText();
        Ball = GetComponent<Rigidbody>();
     }

    void SetpointText()
    {
        pointText.text = "Spelare 1 : " + points.ToString();
        livesText.text = "Life: " + lives.ToString();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Ball.AddForce(-Vector3.right * 30);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Ball.AddForce(Vector3.right * 30);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Ball.AddForce(Vector3.forward * 30);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Ball.AddForce(-Vector3.forward * 30);
        }
        if (lives==0) // Om man inte har några liv så blir gameover true
        {
            SetpointText();
            gameover = true;
        }
        if (gameover) // Laddar en ny scen som heter Highscore
        {
            PlayerPrefs.GetInt("pointText");
            Application.LoadLevel("Highscore");
        }
        if(points>=20) // Förutsättning för att förlora första livet
        {
            if (loselife1 == false)
            {
                lives--;
                loselife1 = true;
                SetpointText();
            }
        }
        if (points >= 30) // Förutsättning för att förlora andra livet
        {
            if (loselife2 == false)
            {
                lives--;
                loselife2 = true;
                SetpointText();
            }
        }
        if (points >= 40) // Förutsättning för att förlora tredje livet
        {
            if (loselife3 == false)
            {
                lives--;
                loselife3 = true;
                SetpointText();
            }
        }
        if (points >= 50) // Förutsättning för att förlora fjärde livet
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
            if (points >= 10) // Förutsättning för att få extraliv
            {
                lives++;
                extraLife = false;
            }

        }
        if(lives == 1) // Om man har ett liv så visas Image1
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