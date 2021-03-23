using TMPro;
using UnityEngine;

public class ScoreTextManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = "SCORE: " + GameControl.SCORE;
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + GameControl.SCORE;
    }
}