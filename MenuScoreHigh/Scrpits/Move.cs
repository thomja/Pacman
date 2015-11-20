using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Move : MonoBehaviour
{
    private int points;
    public Text pointText;
    private Rigidbody Ball;
    private GameObject Pill;
    private GameObject Fruit;
    static bool gameover;

    void Awake()
    {
        gameover = false;
        points = 0;
        Ball = GetComponent<Rigidbody>();
        SetpointText();
    }
    void SetpointText()
    {
        pointText.text = "Spelare 1:   " + points.ToString();
    }
   
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            Ball.AddForce(transform.forward * 20);
        if (Input.GetKey(KeyCode.DownArrow))
            Ball.AddForce(-transform.forward * 20);
        if (Input.GetKey(KeyCode.LeftArrow))
            Ball.AddForce(-transform.right * 20);
        if (Input.GetKey(KeyCode.RightArrow))
            Ball.AddForce(transform.right * 20);
        if (points == 1510)
        {
            gameover = true;
        }
    }
    void Update()
    {
        if (gameover)
        {
            Application.LoadLevel("Highscore");
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