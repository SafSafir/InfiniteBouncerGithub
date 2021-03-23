using UnityEngine;
using UnityEngine.SceneManagement;

public class InsideMenuButtonManager : MonoBehaviour
{
    public void PressInsideMenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
        Time.timeScale = 1;
        GameControl.SCORE = 0;
        StickMovement.fallSpeed = 4.428453f;
        BallMovement.Delay = 0.6700001f;
        BallMovement.thrustY = 17.5f;
        Physics2D.gravity = new Vector2(0, -9.8f);
        MainMenuButtonManager.isPressedMenu = false;
    }
}