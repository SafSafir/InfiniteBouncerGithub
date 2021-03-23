using UnityEngine;
using UnityEngine.UI;

public class GoLeftButtonManager : MonoBehaviour
{
    public Sprite[] spriteArr;
    public GameObject imaj;

    private void Start()
    {
        SkinControl.skinNumber = PlayerPrefs.GetInt("SkinNumber", SkinControl.skinNumber);
    }

    private void Update()
    {
    }

    public void PressGoLeftButton()
    {
        if (SkinControl.skinNumber > 0)
        {
            imaj.GetComponent<RawImage>().texture = spriteArr[--SkinControl.skinNumber].texture;
        }
        else
        {
            SkinControl.skinNumber = spriteArr.Length - 1;
            imaj.GetComponent<RawImage>().texture = spriteArr[SkinControl.skinNumber].texture;
        }
        PlayerPrefs.SetInt("SkinNumber", SkinControl.skinNumber);
    }
}