using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonManager : MonoBehaviour
{
    public void PressPlay()
    {
        GameControl.SCORE = 0;
        StickMovement.fallSpeed = 4.428453f;
        BallMovement.Delay = 0.6700001f;
        BallMovement.thrustY = 17.5f;
        GameControl.G = -41.2f;
        MainMenuButtonManager.isPressedMenu = false;
        SceneManager.LoadScene("GameScene");
    }
}