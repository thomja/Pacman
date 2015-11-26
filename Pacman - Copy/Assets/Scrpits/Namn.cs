using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Namn : MonoBehaviour
{
    public static string SpelarNamn;
    public static string namn;

    public void Awake()
    {
        PlayerPrefs.SetString("SpelarNamn", "Spelare 1");
        PlayerPrefs.Save();
    }
}
