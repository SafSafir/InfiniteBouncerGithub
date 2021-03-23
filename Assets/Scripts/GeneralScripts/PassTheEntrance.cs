using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassTheEntrance : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(PassGeneric());
    }

    private IEnumerator PassGeneric()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenuScene");
    }
}