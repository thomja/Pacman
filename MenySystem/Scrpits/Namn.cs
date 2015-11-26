using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Namn : MonoBehaviour
{
    public static string SpelarNamn;

    public void Update()
    {
        PlayerPrefs.SetString("Namn", SpelarNamn);
        PlayerPrefs.Save();
    }
}
