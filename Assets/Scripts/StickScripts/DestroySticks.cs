using TMPro;
using UnityEngine;

public class DestroySticks : MonoBehaviour
{
    public TMP_Text deadText;
    public GameObject replayButton;
    public GameObject insideMenuButton;
    public GameObject mainMenuButton;
    public AudioSource gameSound;
    public AudioSource gameOverSound;
    private int nonRealScore = 0;
    static public bool isDead;
    static public int highScore;

    private void Start()
    {
        isDead = false;
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
        GameControl.coinCounter = PlayerPrefs.GetInt("CoinNumber", GameControl.coinCounter);
    }

    private void Update()
    {
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "middle" || other.gameObject.tag == "right" || other.gameObject.tag == "left")
        {
            Destroy(other.transform.root.gameObject);
            nonRealScore++;
            if (nonRealScore % 9 == 0)
            {
                GameControl.SCORE += 10;
            }
        }

        if (other.gameObject.tag == "ball")
        {
            DoWhenYouAreDie();
        }
    }

    private void DoWhenYouAreDie()
    {
        Time.timeScale = 0;
        deadText.text = "Game Over";
        replayButton.SetActive(true);
        insideMenuButton.SetActive(true);
        mainMenuButton.SetActive(false);
        isDead = true;
        gameSound.Stop();
        gameOverSound.Play();
        PlayerPrefs.SetInt("CoinNumber", GameControl.coinCounter);

        if (GameControl.SCORE > highScore)
        {
            highScore = GameControl.SCORE;
            PlayerPrefs.SetInt("HighScore", highScore);
            deadText.text = "GAME OVER";
        }
    }
}