using TMPro;
using UnityEngine;

public class GameSceneCoinCounterControl : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = GameControl.coinCounter.ToString();
    }

    private void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = GameControl.coinCounter.ToString();
    }
}