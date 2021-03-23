using UnityEngine;
using UnityEngine.UI;

public class SkinControl : MonoBehaviour
{
    static public int skinNumber = 0;
    public GameObject ballImage;
    public Sprite[] spriteArr;
    public int[] flagArr;
    static public Sprite currentSprite;
    public Image pickButton;
    public Sprite[] takenOrNot;
    public GameObject price;
    public GameObject coin;

    private void Start()
    {
        GameControl.isInGameScene = false;
        for (int m = 0; m < flagArr.Length; m++)
        {
            if (PlayerPrefs.GetInt("flagReminder" + m, 0) == 1)
            {
                flagArr[m] = 1;
            }
        }
        currentSprite = spriteArr[PlayerPrefs.GetInt("PlayerPrefI", 0)];
        ChangePickButton();
    }

    private void Update()
    {
    }

    public void PressPurchaseButton()
    {
        for (int i = 0; i < spriteArr.Length; i++)
        {
            if (ballImage.GetComponent<RawImage>().texture.name == spriteArr[i].name)
            {
                if ((PlayerPrefs.GetInt("CoinNumber", GameControl.coinCounter) >= 35) && (flagArr[i] == 0))
                {
                    flagArr[i] = 1;
                    currentSprite = spriteArr[i];
                    PlayerPrefs.SetInt("PlayerPrefI", i);
                    PlayerPrefs.SetInt("CoinNumber", PlayerPrefs.GetInt("CoinNumber", GameControl.coinCounter) - 35);
                    PlayerPrefs.SetInt("flagReminder" + i, 1);
                    ChangePickButton();
                    break;
                }
                else if (flagArr[i] == 1)
                {
                    currentSprite = spriteArr[i];
                    PlayerPrefs.SetInt("PlayerPrefI", i);
                    ChangePickButton();
                    break;
                }
            }
        }
    }

    public void ChangePickButton()
    {
        for (int i = 0; i < spriteArr.Length; i++)
        {
            if (ballImage.GetComponent<RawImage>().texture.name == spriteArr[i].name)
            {
                if (currentSprite == spriteArr[i])
                {
                    pickButton.GetComponent<Image>().sprite = takenOrNot[2];
                    coin.SetActive(false);
                    price.SetActive(false);
                }
                else if (flagArr[i] == 1)
                {
                    pickButton.GetComponent<Image>().sprite = takenOrNot[1];
                    coin.SetActive(false);
                    price.SetActive(false);
                    break;
                }
                else
                {
                    pickButton.GetComponent<Image>().sprite = takenOrNot[0];
                    coin.SetActive(true);
                    price.SetActive(true);
                    break;
                }
            }
        }
    }
}