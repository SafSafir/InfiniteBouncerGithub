using UnityEngine;

public class MainMenuButtonManager : MonoBehaviour
{
    public GameObject replayButton;
    public GameObject insideMenuButton;
    public GameObject continueButton;
    public GameObject slider;
    public AudioSource gameSound;
    static public bool isPressedMenu = false;

    public void PressMainMenuButton()
    {
        isPressedMenu = true;
        Time.timeScale = 0;
        insideMenuButton.SetActive(true);
        continueButton.SetActive(true);
        slider.SetActive(true);
        gameSound.Pause();
    }
}