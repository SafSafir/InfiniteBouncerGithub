using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinsButtonManager : MonoBehaviour
{
    public void PressSkins()
    {
        SceneManager.LoadScene("SkinScene");
    }
}