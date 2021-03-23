using UnityEngine;
using UnityEngine.UI;

public class GoRightButtonManager : MonoBehaviour
{
    public Sprite[] spriteArr;
    public GameObject imaj;

    private void Start()
    {
        SkinControl.skinNumber = PlayerPrefs.GetInt("SkinNumber", SkinControl.skinNumber);
        imaj.GetComponent<RawImage>().texture = spriteArr[SkinControl.skinNumber].texture;
    }

    private void Update()
    {
    }

    public void PressGoRightButton()
    {
        if (SkinControl.skinNumber < spriteArr.Length - 1)
        {
            imaj.GetComponent<RawImage>().texture = spriteArr[++SkinControl.skinNumber].texture;
        }
        else
        {
            SkinControl.skinNumber = 0;
            imaj.GetComponent<RawImage>().texture = spriteArr[SkinControl.skinNumber].texture;
        }
        PlayerPrefs.SetInt("SkinNumber", SkinControl.skinNumber);
    }
}