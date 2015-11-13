using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    static int score;
    private Rigidbody Ball;
    private GameObject Pill;
    private GameObject Fruit;
    public GUIStyle Style = null;

    void Start()
    {
        Ball = GetComponent<Rigidbody>();
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
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Pill")
        {
            score += 10;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Fruit")
        {
            score += 500;
            Destroy(col.gameObject);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Spelare 1 " + score, Style);        
    }
}