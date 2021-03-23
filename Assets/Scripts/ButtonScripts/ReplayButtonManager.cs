using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtonManager : MonoBehaviour
{
    public void PressReplay()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        GameControl.SCORE = 0;
        StickMovement.fallSpeed = 4.428453f;
        BallMovement.Delay = 0.6700001f;
        BallMovement.thrustY = 17.5f;
        GameControl.G = -41.2f;
        MainMenuButtonManager.isPressedMenu = false;
    }
}