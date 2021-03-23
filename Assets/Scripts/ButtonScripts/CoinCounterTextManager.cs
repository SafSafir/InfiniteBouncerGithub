using TMPro;
using UnityEngine;

public class CoinCounterTextManager : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("CoinNumber", GameControl.coinCounter).ToString();
    }

    private void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("CoinNumber", GameControl.coinCounter).ToString();
    }
}