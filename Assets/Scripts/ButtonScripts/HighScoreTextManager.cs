using TMPro;
using UnityEngine;

public class HighScoreTextManager : MonoBehaviour
{
    public TMP_Text highScoreText;

    private void Start()
    {
        highScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("HighScore");
    }

    private void Update()
    {
        highScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("HighScore");
    }
}