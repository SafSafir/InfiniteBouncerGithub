using UnityEngine;

public class ContinueButtonManager : MonoBehaviour
{
    public GameObject replayButton;
    public GameObject menuButton;
    public GameObject insideMenuButton;
    public AudioSource gameSound;
    public GameObject slider;

    public void PressContinueButton()
    {
        slider.SetActive(false);
        replayButton.SetActive(false);
        insideMenuButton.SetActive(false);
        gameObject.SetActive(false);
        Time.timeScale = 1;
        MainMenuButtonManager.isPressedMenu = false;
        gameSound.UnPause();
    }
}