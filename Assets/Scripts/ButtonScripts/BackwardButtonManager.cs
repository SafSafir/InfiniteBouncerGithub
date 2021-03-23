using UnityEngine;
using UnityEngine.SceneManagement;

public class BackwardButtonManager : MonoBehaviour
{
    public void PressBackwardButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}